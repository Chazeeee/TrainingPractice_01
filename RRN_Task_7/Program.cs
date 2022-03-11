using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRN_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random shuffle = new Random();
            Console.Write("Введите количество элементов в массиве: ");
            int count;
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arrayUs = new int[count];
            for (int i = 0; i < count; i++)
            {
                int rand1 = shuffle.Next(-100, 100);
                arrayUs[i] = rand1;
                Console.WriteLine("{0} элемент массива до функции shuffle = {1}", i + 1, arrayUs[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                int rand2 = shuffle.Next(i);
                var temp = arrayUs[rand2];
                arrayUs[rand2] = arrayUs[i];
                arrayUs[i] = temp;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} элемент массива после функции shuffle = {1}", i + 1, arrayUs[i]);

            }
            Console.ReadKey();
        }
    }
}
