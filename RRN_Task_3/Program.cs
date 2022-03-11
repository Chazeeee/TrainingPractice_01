using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRN_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "1234";
            string inputPassword = "";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль: ");
                inputPassword = Console.ReadLine();
                if (inputPassword == correctPassword)
                {
                    Console.WriteLine("Введен верный пароль! " + correctPassword);
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неверный пароль, попробуйте еще раз");
                }
            }

        }
    }
}
