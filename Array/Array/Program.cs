using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Array
    {
        public static void Main()
        {
            int i, j, k, n, sum = 0, d = 1;
            int[] a = new int[100];


            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} the elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element  {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Given Array: ");
            for (i = 0; i < n; i++)
            {

                Console.Write("{0}  ", a[i]);
            }

            Console.WriteLine();
            //Array Reverse
            Console.WriteLine("Array in reverse order: ");

            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            //array Sum
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            
            Console.Write("\nSum of the array elements= {0}  ", sum);
           //COPY ARRAY
            int[] a2 = new int[100];
            for (i = 0; i < n; i++)
            {
                a2[i] = a[i];
            }
            Console.WriteLine("\nThe 1st Array:  ");
            for (i = 0; i < n; i++)
            {

                Console.Write("{0}  ", a[i]);
            }
            Console.WriteLine("\nThe 2nd Array:  ");
            for (i = 0; i < n; i++)
            {

                Console.Write("{0}  ", a2[i]);
            }
           //DUPLICATE ELEMENTS COUNT
            int[] a3 = new int[100];
            int max = 0;

            for (i = 0; i < n; i++)
            {
                a3[i] = a[i];
            }

            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            int[] tmp = new int[max + 1];

            for (int m = 0; m < tmp.Length; m++)
                tmp[m] = 0;

            for (i = 0; i < n; i++)
            {
                d = 1;
                for (j = i; j <= n; j++)
                {
                    if (tmp[a[i]] != -1 && a[i] == a3[j])
                    {
                        d++;
                    }
                }
                tmp[a[i]] = -1;
                if (d > 1)
                {
                    Console.Write("\ncount of duplicate {0}= {1}  ", a[i], d - 1);
                }
                //  d = 1;


            }
            // UNIQUE ELEMENTS
            Console.Write("\nThe unique elements found in the array are: \n");
            for (i = 0; i < n; i++)
            {
                int U = 0;
                for (j = 0, k = n; j < k + 1; j++)
                {

                    if (i != j)
                    {
                        if (a[i] == a[j])
                        {
                            U++;
                        }
                    }
                }
                if (U == 0)
                {
                    Console.Write(" {0}  ", a[i]);
                }
            }
        }
    }  
}
