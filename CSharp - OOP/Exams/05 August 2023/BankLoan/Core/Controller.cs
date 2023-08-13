using BankLoan.Core.Contracts;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Repositories.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IBank> banks;
        private readonly IRepository<ILoan> loans;
        public Controller()
        {
            this.banks = new BankRepository();
            this.loans = new LoanRepository();
        }
        public string AddBank(string bankTypeName, string name)
        {
            IBank bank;
            if (bankTypeName == "BranchBank")
            {
                 bank = new BranchBank(name);
            }
            else if(bankTypeName == "CentralBank")
            {
                 bank = new CentralBank(name);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.BankTypeInvalid);
            }

            this.banks.AddModel(bank);
            return string.Format(OutputMessages.BankSuccessfullyAdded, bankTypeName);
            

        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
            IClient client;
            if(clientTypeName == "Student")
            {
                client = new Student(clientName, id, income);
            }
            else if(clientTypeName == "Adult")
            {
                client = new Adult(clientName, id, income);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.ClientTypeInvalid);
            }

            IBank bank = banks.FirstModel(bankName);
            if((bank.GetType().Name == nameof(BranchBank) && clientTypeName != "Student") || 
                (bank.GetType().Name == nameof(CentralBank) && clientTypeName != "Adult"))
            {
                return string.Format(OutputMessages.UnsuitableBank);
            }
            bank.AddClient(client);
            return string.Format(OutputMessages.ClientAddedSuccessfully, clientTypeName, bankName);
        }

        public string AddLoan(string loanTypeName)
        {
            ILoan loan;
            if(loanTypeName == "StudentLoan")
            {
                loan = new StudentLoan();
            }
            else if(loanTypeName == "MortgageLoan")
            {
                loan = new MortgageLoan();
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.LoanTypeInvalid);
            }
            this.loans.AddModel(loan);
            return string.Format(OutputMessages.LoanSuccessfullyAdded, loanTypeName);
        }

        public string FinalCalculation(string bankName)
        {
           IBank bank = this.banks.FirstModel(bankName);
            var incomeSum = bank.Clients.Sum(x => x.Income);
            var amountSum = bank.Loans.Sum(x => x.Amount);
            return string.Format(OutputMessages.BankFundsCalculated, bankName, $"{(incomeSum + amountSum):f2}");
        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            ILoan loan = this.loans.FirstModel(loanTypeName);
            if(loan == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MissingLoanFromType, loanTypeName));
            }

            IBank bank = this.banks.FirstModel(bankName);
            bank.AddLoan(loan);
            this.loans.RemoveModel(loan);
            return string.Format(OutputMessages.LoanReturnedSuccessfully, loanTypeName, bankName);
        }

        public string Statistics()
        {
            StringBuilder sb = new StringBuilder();

            foreach(var bank in this.banks.Models)
            {
                sb.AppendLine(bank.GetStatistics());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
