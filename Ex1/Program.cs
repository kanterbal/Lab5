using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            float s = 0;
            int[] array = new int[n];
            Console.WriteLine("Введите {0} чисел массива", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int a in array)
            {
                s += a;
            }
            Console.WriteLine("Среднее арифметическое элементов = {0:f2}", s / n);
            Console.ReadKey();
        }
    }
}
