using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] stroka = new int[n];
            int[] stolbec = new int[n];
            int d1 = 0, d2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    stroka[i] += array[i, j];
                    stolbec[j] += array[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                d1 += array[i, i];
                d2 += array[i, n - i - 1];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            int check = stroka[0];
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                if (stroka[i] != check || stolbec[i] != check || d1 != check || d2 != check)
                {
                    Console.WriteLine("Матрица не является магической");
                    break;
                }
                else
                {
                    t += 1;
                }
            }
            if (t == n)
            {
                Console.WriteLine("Матрица является магической");
            }
            Console.ReadKey();
        }
    }
}
