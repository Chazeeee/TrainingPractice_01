using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRN_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас золота?");
            string temp_gold;
            int gold;
            temp_gold = Console.ReadLine();
            bool test = int.TryParse(temp_gold, out gold);
            if (test)
            {
                if (gold < 0)
                {
                    Console.WriteLine("У вас отрицательный баланс!");
                }
                else
                {
                    int buy_crystal;
                    int crystal_price = 6;
                    Console.WriteLine("Вы можете купить MAX: " + gold / crystal_price + " кристалов по цене: " + crystal_price + " за штуку");
                    Console.WriteLine("Сколько хотите купить кристалов?");
                    buy_crystal = Convert.ToInt32(Console.ReadLine());
                    int max_buy_crystal = gold / crystal_price;
                        if (buy_crystal < 0)
                        {
                            Console.WriteLine("Вы не можете купить отрицательное количество кристалов!!");
                        }
                        else
                        {
                            if (buy_crystal > max_buy_crystal)
                            {
                                Console.WriteLine("Вы не можете купить такое кол-во кристалов " + ", у вас  " + gold + " золота. ");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Вы купили " + buy_crystal + " кристалов. У вас осталось " + (gold - buy_crystal * crystal_price) + " золота");
                                Console.ReadKey();
                            }
                        }
                    
                }
            }
            else 
            {
                Console.WriteLine("Вы ввели не число");
            }
        }
    }
}
