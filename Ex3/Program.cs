using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n/2-1; i++)
            {
                for (int j = i+1; j < n/2; j++)
                {
                    if (array[i]>array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = n/2; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[i])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            foreach (int a in array)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadKey();
        }
    }
}
