using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SpecialCurrent : Account
    {
        public SpecialSavings(int MaxNumofTransaction) : base()
        {
            this.MaxNumOfTransaction = MaxNumOfTransaction;
        }
        public SpecialSavings(string name, int? accNo, double balance, int MaxNumOfTransactions)
            : base(name, accNo, balance)
        {
            this.MaxNumOfTransaction = MaxNumOfTransaction;
        }
        public override void Withdraw(double amount)
        {
            if (numOfTransaction <= MaxNumOfTransaction && Balance - amount >= amount * 10 / 100)
            {
                Balance -= amount;
                numOfTransaction++;
            }
            else
            {
                Console.WriteLine("Given amount exceeds the minimum balance");
            }
        }
    }
}
