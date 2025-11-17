using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneMealPass.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MealPass.Core.GlobalSql;
using MealPass.Data.Repositories;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class EditPasswordRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly string _username;

        public EditPasswordRibbonForm(string username)
        {
            InitializeComponent();
            _username = username;

            passwordBE.Tag = "eyeopen";
            confirmpassBE.Tag = "eyeopen";

            ApplyTextEditBehaviors();
            lblConfirmPasswordCaption.Visible = false;
        }

        private void ApplyTextEditBehaviors()
        {
            Helpers.TextHelper.AttachBehavior(passwordBE, "Password", true);
            Helpers.TextHelper.AttachBehavior(confirmpassBE, "Password", true);

        }

        private void passwordBE_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ToggleEye(passwordBE);
        }

        private void passwordBE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
            string message = "";

            if (string.IsNullOrWhiteSpace(password))
            {
                resultcaptionLBL.Visible = false;
                resultLBL.Visible = false;
                return;
            }

            resultcaptionLBL.Visible = true;
            resultLBL.Visible = true;

            if (password.Length < 8)
                message += " - Must be at least 8 characters long\n";
            if (!password.Any(char.IsUpper))
                message += " - Must contain at least one uppercase letter\n";
            if (!password.Any(char.IsLower))
                message += " - Must contain at least one lowercase letter\n";
            if (!password.Any(char.IsDigit))
                message += " - Must contain at least one number\n";
            if (!password.All(char.IsLetterOrDigit))
                message += " - Must not contain special characters\n";

            if (string.IsNullOrEmpty(message))
            {
                resultcaptionLBL.Text = "✅ Password is valid!";
                resultLBL.Text = message;
                resultcaptionLBL.ForeColor = Color.PaleGreen;
                resultLBL.ForeColor = Color.PaleGreen;
            }
            else
            {
                resultcaptionLBL.Text = "❌ Password is invalid";
                resultLBL.Text = message;
                resultcaptionLBL.ForeColor = Color.LightCoral;
                resultLBL.ForeColor = Color.LightCoral;
            }
        }

        private void confirmpassBE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
            string confirmPassword = confirmpassBE.Text;

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblConfirmPasswordCaption.Visible = false;
                lblConfirmPasswordCaption.Text = string.Empty;
                return;
            }

            lblConfirmPasswordCaption.Visible = true;

            if (password == confirmPassword)
            {
                lblConfirmPasswordCaption.Text = "✅  Password confirmed!";
                lblConfirmPasswordCaption.ForeColor = Color.PaleGreen;
            }
            else
            {
                lblConfirmPasswordCaption.Text = "❌  Password mismatch";
                lblConfirmPasswordCaption.ForeColor = Color.LightCoral;
            }
        }

        private async Task saveBTN_Click(object sender, EventArgs e)
        {
            string newPassword = passwordBE.Text;
            string confirmPassword = confirmpassBE.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (newPassword.Length < 8 ||
                !newPassword.Any(char.IsUpper) ||
                !newPassword.Any(char.IsLower) ||
                !newPassword.Any(char.IsDigit) ||
                !newPassword.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Password does not meet the requirements.");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            using (SqlConnection connection = new SqlConnection(SQLQuery.connectionString))
            {
                connection.Open();
                string query = "UPDATE dbo.Employees SET Password = @password, FailedAttempts = 0, IsLocked = 0 WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@username", _username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        await GlobalLogger.EmployeeLogAsync($"{UserSession.Username} modified employee password.", UserSession.Username);
                        MessageBox.Show("Password updated successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
            }
        }

        private void confirmpassBE_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ToggleEye(confirmpassBE);
        }

        private void ToggleEye(DevExpress.XtraEditors.ButtonEdit edit)
        {
            edit.Properties.UseSystemPasswordChar = !edit.Properties.UseSystemPasswordChar;

            if (edit.Properties.UseSystemPasswordChar)
                edit.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0]; 
            else
                edit.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1]; 
        }
    }
}