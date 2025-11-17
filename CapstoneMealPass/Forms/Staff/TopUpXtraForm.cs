using CapstoneMealPass.Helpers;
using DevExpress.XtraEditors;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapstoneMealPass.Forms.Staff
{
    public partial class TopUpXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly TopUpService _topUpService;
        private readonly RFIDReaderService _rfidReader;
        private string _scannedRfid;
        private string _currentStudentId;
        private readonly ScanRFIDXtraForm _scanForm;
        private readonly decimal? _initialBalance;
        private readonly string _initialStudentId;
        private readonly bool _rfidRequired = true;


        // Constructor for ScanRFIDXtraForm context
        public TopUpXtraForm(string studentId, decimal balance, ScanRFIDXtraForm scanForm)
        {
            InitializeComponent();

            string connectionString = SQLQuery.connectionString;

            IStudentRepository studentRepo = new StudentRepository(connectionString);
            IBalanceRepository balanceRepo = new BalanceRepository(connectionString);

            _topUpService = new TopUpService(studentRepo, balanceRepo);
            _rfidReader = null;
            _scanForm = scanForm;

            _currentStudentId = studentId;
            _initialBalance = balance;
            _initialStudentId = studentId;
            _rfidRequired = false; // RFID not needed
        }

        // Default constructor for standalone use
        public TopUpXtraForm()
        {
            InitializeComponent();

            string connectionString = SQLQuery.connectionString;
            IStudentRepository studentRepo = new StudentRepository(connectionString);
            IBalanceRepository balanceRepo = new BalanceRepository(connectionString);

            _topUpService = new TopUpService(studentRepo, balanceRepo);
            _rfidReader = new RFIDReaderService();
        }

        private async void confirmBTN_Click(object sender, EventArgs e)
        {
            if (_rfidRequired && string.IsNullOrEmpty(_scannedRfid))
            {
                MessageBox.Show("Please scan an RFID card first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(topupamountTE.Text, out decimal topUpAmount) || topUpAmount <= 0)
            {
                MessageBox.Show("Please enter a valid top-up amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal previousBalance = 0m;
                if (decimal.TryParse(accountbalanceLBL.Text, out decimal parsedBal))
                    previousBalance = parsedBal;

                await _topUpService.TopUpAsync(_currentStudentId, topUpAmount);

                decimal newBalance = previousBalance + topUpAmount;

                string connectionString = SQLQuery.connectionString;
                var logRepo = new TopUpLogRepository(connectionString);

                var log = new TopUpLog
                {
                    StudentID = _currentStudentId,
                    Username = UserSession.Username,
                    Amount = topUpAmount,
                    PreviousBalance = previousBalance,
                    NewBalance = newBalance,
                    TopUpDate = DateTime.Now,
                    Status = "Completed"
                };

                await logRepo.InsertTopUpLogAsync(log);

                MessageBox.Show("Top-up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadStudentInfoAsync(_scannedRfid);

                if (_scanForm != null)
                    await _scanForm.RefreshStudentBalanceAsync(_currentStudentId);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing top-up: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TopUpXtraForm_Load(object sender, EventArgs e)
        {
            studentidTE.ReadOnly = true;

            if (!string.IsNullOrEmpty(_initialStudentId) && _initialBalance.HasValue)
            {
                studentidTE.Text = _initialStudentId;
                accountbalanceLBL.Text = $"{_initialBalance.Value:N2}";
                statusLBL.Text = "Ready for top-up";
                return; // Skip RFID setup
            }

            if (_rfidReader == null) return;

            _rfidReader.OnStatusChanged += (status) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => statusLBL.Text = status));
                else
                    statusLBL.Text = status;
            };

            _rfidReader.OnCardScanned += async (rfid) =>
            {
                _scannedRfid = rfid;
                await LoadStudentInfoAsync(rfid);
            };

            _rfidReader.OnCardRemoved += () =>
            {
                if (!IsHandleCreated || IsDisposed || statusLBL == null) return;

                if (InvokeRequired)
                    Invoke(new Action(() => statusLBL.Text = "Waiting for card..."));
                else
                    statusLBL.Text = "Waiting for card...";
            };

            _rfidReader.Initialize();
        }

        private async Task LoadStudentInfoAsync(string rfid)
        {
            try
            {
                // Always ensures student + balance record exist
                var (student, balance) = await _topUpService.GetOrCreateStudentBalanceByRFIDAsync(rfid);

                if (student == null)
                {
                    Invoke(new Action(() =>
                    {
                        statusLBL.Text = "⚠️ Unknown RFID";
                        studentidTE.Text = string.Empty;
                        accountbalanceLBL.Text = "0.00";
                    }));
                    _currentStudentId = "";
                    return;
                }

                _currentStudentId = student.StudentID;

                // Safely handle even if balance is temporarily null
                decimal displayBalance = balance?.StudentBalance ?? 0m;

                Invoke(new Action(() =>
                {
                    studentidTE.Text = student.StudentID;
                    accountbalanceLBL.Text = $"{displayBalance:N2}";
                    statusLBL.Text = "Connected";
                }));
            }
            catch (Exception ex)
            {
                if (!IsHandleCreated || IsDisposed) return;

                Invoke(new Action(() =>
                {
                    MessageBox.Show($"Error loading student info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }
    }
}
