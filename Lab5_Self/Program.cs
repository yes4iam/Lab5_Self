using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива");
            int[] array = new int[7];
            int s = 0;
            int k = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 7; i++)
            {
                s += array[i];
                k++;
            }
            Console.WriteLine("Среднее арифметическое чисел:");
            Console.WriteLine(((double)s)/k);
            
            Console.ReadKey();

        }
    }
}
