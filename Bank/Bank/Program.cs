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
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("          Savings         ");
            Console.WriteLine("\n");

            Savings s1 = new Savings("JUI", "1234", 5000);
            Savings s2 = new Savings("MAHFUZA", "4321", 4000);
            s1.Withdraw(500);
            s1.Deposit(1000);
            s1.Transfer(1000, s2);

            s1.ShowInfo();
            s2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("          Special         ");
            Console.WriteLine("\n");

            SpecialCurrent sc1 = new SpecialCurrent("SHARMILI", "1234", 5000);
            SpecialCurrent sc2 = new SpecialCurrent("RINTY", "4321", 4000);
            sc1.Withdraw(500);
            sc1.Deposit(1000);
            sc1.Transfer(5000, sc2);

            sc1.ShowInfo();
            sc2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("           Fixed          ");
            Console.WriteLine("\n");

            Fixed f1 = new Fixed("HIA", "1234", 5000, 4);
            Fixed f2 = new Fixed("BRISTY", "4321", 4000, 3);
            f1.Withdraw(500);
            f1.Deposit(1000);
            f1.Transfer(5000, f2);

            f1.ShowInfo();
            f2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("         OverDraft        ");
            Console.WriteLine("\n");

            OverDraft od1 = new OverDraft("JUI", "1234", 5000);
            OverDraft od2 = new OverDraft("MAHFUZA", "4321", 4000);
            od1.Withdraw(500);
            od1.Deposit(1000);
            od1.Transfer(5000, od2);

            od1.ShowInfo();
            od2.ShowInfo();
        }
    }
    }

