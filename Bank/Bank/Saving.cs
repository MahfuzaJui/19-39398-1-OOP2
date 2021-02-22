using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Savings : Account
    {
        private int minBalance = 430;
        public Savings() { }
        public Savings(string accName, string accid, int balance) : base(accName, accid, balance) { }

        public int MinBalance
        {
            get { return this.minBalance; }
        }

        public override void Withdraw(int amount)
        {
            if (this.MinBalance < this.Balance - amount)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("[Error]: You've exceeded your minimum balance!!");
                Console.WriteLine();
            }
        }

        public override void Deposit(int amount) { base.Deposit(amount); }

        public override void Transfer(int amount, Account acc)
        {
            if (this.MinBalance < base.Balance - amount)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine("[Error]: You've exceeded your minimum balance!!");
                Console.WriteLine();
            }
        }
    }
}
