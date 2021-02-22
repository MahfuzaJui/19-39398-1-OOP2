using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        int amount;
        Account acc;


        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }

        public Account Acc
        {
            set { acc = value; }
            get { return acc; }
        }

        public Account()
        {
            
        }

        public Account(string accName, string acid, int balance)
        {
            Console.WriteLine("Account Created ");
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void deposit(int amount)
        {
            if (balance > 0)
            {
                balance = balance + amount;
                Console.WriteLine("After Deposite: " + balance);
            }
            else
            {
                Console.WriteLine("Not Deposited.");
            }

        }

        public void withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("After Withdrawal: " + balance);
            }
            else
            {
                Console.WriteLine("Can not Withdraw.");
            }
        }


        public void Transfer(int amount, Account acc)
        {
            if (amount > 0 && amount <= balance)
            {


                Console.WriteLine("Transferred amount:" + amount);
                balance = balance - amount;
                Console.WriteLine("Balance After Transfer:" + this.balance);
                balance = balance + amount;
                Console.WriteLine("Recieved amount:" + amount);

            }
            else
                Console.WriteLine("Amount Exceeded");
        }
            
        




        public void  ShowInfo()
        {
            Console.WriteLine("Account Name : " + accName);
            Console.WriteLine("ID : " + acid);
            Console.WriteLine("Balance : " + balance);
        }
    }
}
