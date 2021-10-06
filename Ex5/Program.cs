using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            bool t = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (t)
                    {
                        array[i, j] = 1;
                        t = !t;
                        continue;
                    }
                    if (!t)
                    {
                        array[i, j] = 0;
                        t = !t;
                        continue;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
