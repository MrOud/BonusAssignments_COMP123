using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        private double balance;

        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance {  
            get {
                return balance;
            } 
        }

        public BankAccount(int accountNumber, string customerName, double balance) {
            this.AccountNumber = accountNumber;
            this.CustomerName = customerName;
            this.balance = balance;
        }

        public void Deposit (double amount) {
            if (amount <= 0) throw new ArgumentOutOfRangeException("Amount cannot be 0 or negative");
            this.balance += amount;
        }

        public void Withdraw (double amount) {
            if (amount <= 0 ) throw new ArgumentOutOfRangeException("Amount cannot be 0 or negative");
            if (this.balance < amount) throw new ArgumentOutOfRangeException("Amount cannot be greater than the Balance");

            this.balance -= amount; //Will only run if the first two tests don't throw
        }

    }
}
