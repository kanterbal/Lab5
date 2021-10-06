using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            Random random = new Random();
            int[] array = new int[n];
                        for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine("Сумма максимального и минимального элемента массива = {0}", min + max);
            Console.ReadKey();
        }
    }
}
