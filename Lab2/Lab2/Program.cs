using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
                   
        {
            int n = 100;


            Console.Write("Even Numbers: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                 
                    Console.Write(i + ", ");
                 }
                
            }
            Console.WriteLine("");
        }
    }
}
