using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        public string AccountHolderName { get; set; }
        public string AccId { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Console.WriteLine("Empty Student Constructor .");
        }
        public Account(string accName, string acId, double balance)
        {
            AccountHolderName = accName;
            AccId = acId;
            Balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposite amount : " + amount);
            }
        }
        abstract public void Withdraw(int amount);

        public void Transfer(int amount, Account receiver)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                receiver.Balance += amount;
            }
            else
                Console.WriteLine("Transection failed .");

        }
        abstract public void ShowInfo();

    }
}
