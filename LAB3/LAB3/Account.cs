using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account() { }

        public Account(string accName, string acid, int balance)
        {
            this.AccName = accName;
            this.Acid = acid;
            this.Balance = balance;
        }

        public string AccName
        {
            set { this.accName = value; }
            get { return this.accName; }
        }

        public string Acid
        {
            set { this.acid = value; }
            get { return this.acid; }
        }

        public int Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine(" Amount is higher than balance!!");
            }
            else
            {
                this.Balance -= amount;
            }
        }
    }
}
