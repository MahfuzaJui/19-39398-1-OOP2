using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Section M");
            int a = 10;
            Console.WriteLine("The Variable is " + a);
            float f = 10.578f;
            Console.WriteLine("The value of f is {0} ",f);
            Console.WriteLine("The value of a is {0} and f is {1}",a,f);
            //implicit casting
            short s = 10;//a cup of tea
            int i;//an empty 
            i = s;
            //explicit casting
            int j = 2876555;//a kettle full of tea
            short h;//an empty cup
            h = (short)j;
            int m = 4;//a kettle with half cup tea
            short n;//an empty cup
            n = (short)m;
            Console.WriteLine("j={0}\nh={1}\n\nm={2}\nn={3}", j, h,m,n);
        }
    }
}
