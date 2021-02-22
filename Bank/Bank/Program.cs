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
            Account a1 = new Account("JUI", "1234", 40000);
            a1.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a1.Transfer(200, a1);
            Console.WriteLine("\n");
            Account a2 = new Account("MAHFUZA", "4321", 10000);
            a2.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a2.Transfer(200, a1);
            Console.WriteLine("\n");
            savings s1 = new savings("SHARMILI", "12905", 1500);
            s1.ShowInfo();
            s1.withdraw(500);
            Console.WriteLine("\n");
            Special_current s2 = new Special_current("JUI", "3215", 35500);
            s2.ShowInfo();
            s2.withdraw(3000);
            Console.WriteLine("\n");
            Fixed f1 = new Fixed("HIA", "5664", 10000);
            f1.ShowInfo();
            f1.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine("\n");
            Overdraft o = new Overdraft("PROTIVA", "3429", 1000);
            o.ShowInfo();
            o.withdraw(200);
            Console.WriteLine();

        }
    }
    }

