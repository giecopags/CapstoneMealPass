using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.Entity;
using MealPass.Core.Interface;

namespace MealPass.Business.Services
{
    public class TopUpService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IBalanceRepository _balanceRepository;

        public TopUpService(IStudentRepository studentRepository, IBalanceRepository balanceRepository)
        {
            _studentRepository = studentRepository;
            _balanceRepository = balanceRepository;
        }

        // Gets student + balance record. Creates balance if missing.
        public async Task<(Student student, Balance balance)> GetOrCreateStudentBalanceByRFIDAsync(string rfid)
        {
            var student = await _studentRepository.GetStudentByRFIDAsync(rfid);
            if (student == null)
                return (null, null);

            var balance = await _balanceRepository.GetBalanceByStudentIDAsync(student.StudentID);

            // If no balance record, insert it
            if (balance == null)
            {
                balance = new Balance
                {
                    StudentID = student.StudentID,
                    StudentBalance = 0
                };
                await _balanceRepository.AddBalanceAsync(balance);

                // Fetch again to ensure we return a populated balance object
                balance = await _balanceRepository.GetBalanceByStudentIDAsync(student.StudentID);
            }

            return (student, balance);
        }


        public async Task<(Student student, Balance balance)> GetStudentAndBalanceByRFIDAsync(string rfid)
        {
            var student = await _studentRepository.GetStudentByRFIDAsync(rfid);
            if (student == null)
                return (null, null);

            var balance = await _balanceRepository.GetBalanceByStudentIDAsync(student.StudentID);
            return (student, balance);
        }

        public async Task<bool> TopUpAsync(string studentId, decimal amount)
        {
            var balance = await _balanceRepository.GetBalanceByStudentIDAsync(studentId);
            if (balance == null)
                return false;

            decimal newBalance = balance.StudentBalance + amount;
            await _balanceRepository.UpdateBalanceAsync(studentId, newBalance);
            return true;
        }
    }
}
