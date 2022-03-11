using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRN_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало цикла, напиши exit для выхода");
            string _exit = "exit";
            string _vod = "";
            while (_vod != _exit)

            {
                Console.Write("Цикл работает, для остановки напиши exit: ");
                _vod = Console.ReadLine();
            }
            Console.WriteLine("Цикл завершен");
            Console.ReadKey();
        }
    }
}
