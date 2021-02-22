using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Saving("JUI", "12344", 5000);
            a1.ShowInfo();
            a1.Deposit(23238);
            a1.Withdraw(12190);
            a1.ShowInfo();
            Console.WriteLine();
            
            Account a2 = new Fixed("JUI", "12344", 5420, 4, 2021);
            a2.ShowInfo();
            a2.Deposit(3000);
            a2.Withdraw(2320);
            a2.ShowInfo();

        }
        }
    }

