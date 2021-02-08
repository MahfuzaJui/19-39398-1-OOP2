using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int oddtotal = 0, eventotal = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    eventotal += i;
                }
                else
                {
                    oddtotal += i;
                }
            }

            Console.WriteLine("Even number sum from 1 to 100: " + eventotal);
            Console.WriteLine("Odd number sum from 1 to 100: " + oddtotal);
        }
    }
}
