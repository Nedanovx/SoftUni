using BankLoan.Models.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Bank : IBank
    {
        private string name;
        private int capacity;
        private readonly List<ILoan> loans;
        private readonly List<IClient> clients;
        protected Bank(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.clients = new List<IClient>();
            this.loans = new List<ILoan>();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.BankNameNullOrWhiteSpace);
                }
                name = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        public IReadOnlyCollection<ILoan> Loans => this.loans;

        public IReadOnlyCollection<IClient> Clients => this.clients;

        public void AddClient(IClient Client)
        {
            if(clients.Count < this.Capacity)
            {
                clients.Add(Client);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughCapacity);
            }
        }

        public void AddLoan(ILoan loan)
        {
            this.loans.Add(loan);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}, Type: {this.GetType().Name}");
            sb.Append("Clients: ");
            if(this.clients.Count == 0)
            {
                sb.AppendLine("none");
            }
            else
            {
                var names = this.clients.Select(x => x.Name).ToArray();
                
                    sb.AppendLine(string.Join(", ", names));
                
            }
            sb.AppendLine($"Loans: {this.loans.Count}, Sum of Rates: {this.SumRates()}");
            return sb.ToString().TrimEnd();
        }

        public void RemoveClient(IClient Client)
        {
            this.clients.Remove(Client);
        }

        public double SumRates()
        {
            if (this.Loans.Count == 0)
            {
                return 0;
            }
            return double.Parse(this.Loans.Select(l => l.InterestRate).Sum().ToString());
        }
    }
}
