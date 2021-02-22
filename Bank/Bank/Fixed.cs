using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Fixed : Account
    {
        public int year = DateTime.Now.Year;

        public Fixed(string name, string id, int balance)
            : base(name, id, balance)
        {
            Console.WriteLine("Fixed account created.");
        }

        new public void withdraw(int withdraw)
        {

            if (withdraw <= Balance)
            {
                Balance = Balance - withdraw;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("New Balance " + Balance);
            }
            else
            {
                Console.WriteLine("Balance is Less then " + withdraw);
            }

        }
    }
}
