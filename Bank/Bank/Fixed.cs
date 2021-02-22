using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Fixed : Account
    {
        private int tenureYear = 5;
        private int year;

        public Fixed() { }
        public Fixed(string accName, string accid, int balance, int year)
            : base(accName, accid, balance)
        {
            this.Year = year;
        }

        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }

        public override void Withdraw(int amount)
        {
            if (tenureYear == this.year)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Error! Account is not mature");
                Console.WriteLine();
            }
        }

        public override void Deposit(int amount)
        {
            base.Deposit(amount);
        }

        public override void Transfer(int amount, Account acc)
        {
            if (tenureYear == this.year)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine("Error! Account is not mature");
                Console.WriteLine();
            }
        }
    }
}
