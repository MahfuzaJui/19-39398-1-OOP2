using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Special_current : Account
    {
        public Special_current(string name, string id, int balance)
            : base(name, id, balance)
        {
            Console.WriteLine("Special current account created.");
        }

        new public void withdraw(int withdraw)
        {
            if (withdraw >= (Balance * 10) / 100)
            {
                if (withdraw <= Balance)
                {
                    Balance = Balance - withdraw;
                    Console.WriteLine("Withdraw done");
                    Console.WriteLine("New Balance " + Balance);
                }
                else
                {
                    Console.WriteLine("Balance is less than " + withdraw);
                }
            }
            else
            {
                Console.WriteLine("Less than " + (Balance * 10) / 100);
            }
        }

    }
}
