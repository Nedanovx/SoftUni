using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public class StudentLoan : Loan
    {
        private const int StudentLoanInterestRate = 1;
        private const double StudentLoanAmount = 10000;

        public StudentLoan() : base(StudentLoanInterestRate, StudentLoanAmount)
        {
        }
    }
}
