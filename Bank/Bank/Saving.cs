using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class savings : Account
    {
        public savings(string name, string id, int balance)
            : base(name, id, balance)
        {
            Console.WriteLine("Account created.");
        }

        new public void withdraw(int withdraw)
        {
            if (withdraw >= 430)
            {
                if (withdraw <= Balance)
                {
                    Balance = Balance - withdraw;
                    Console.WriteLine("Withdraw completed.");
                    Console.WriteLine("New Balance: " + Balance);
                }
                else
                    Console.WriteLine("Balance is less then" + withdraw);
            }
            else
                Console.WriteLine("Withdrawal failed,Not enough Balance");
        }
    }
}
