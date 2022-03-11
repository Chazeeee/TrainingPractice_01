using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRN_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerHP = 300;
            int DragonHP = 1000;

            bool Scream = false;
            bool Still = false;
            string skill = null;

            Console.WriteLine("Добро пожаловать! Вы, Воин.\nВаша задача убить Дракона, используя 5 разных скиллов.\n" +
               "Учтите, что за каждое использованное скилла вы будете получать урон. " +
                "Игра закончится, когда кто нибудь умрет.\nМаксимальное здоровье игрока - 300. Здоровье Дракона - 1000." + "\n");
            Console.WriteLine("Скрим Эйдж. Наносит 75 урона и сбивает с ног существо, вы получаете 15 урона.\n" + "\n" +
                "Украсть Души. Возможно только после использования Скримэйдж. Если вы все сделаете правильно,то дракон получит 75 урона, а вы получите 40 урона.\n" + "\n" +
                "Удар Топором. Возможно только после того как вы Украдёте Души. Если вы выполните условия босс получит 125 урона, а вы получите 25 урона.\n" + "\n" +
                "Мясо Единорога. Спасает вас от атаки босса (то есть вы не получите урон). Также мясо восстановит вам 20 единиц здоровья.\n" + "\n" +
                "Зов Богов. Удар Молнии на 50 урона. Вы получите 25 урона.");

            while (PlayerHP > 0 && DragonHP > 0)
            {
                Console.Write("\n" + "Введите команду:");
                skill = Console.ReadLine();
                if (skill == "Скрим Эйдж")
                {
                    DragonHP -= 75;
                    PlayerHP -= 15;
                    Console.WriteLine("\n" + "Вы сбили с ног дракона и нанесли 75 урона и получили 15 урона. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                    Scream = true;
                }
                else if (skill == "Украсть Души")
                {
                    if (Scream == false)
                    {
                        PlayerHP -= 50;
                        Console.WriteLine("\n" + "Для начала нужно было использовать Скримэйдж! Вы не смогли украсть души! " +
                            "Вы получили 50 урона. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                    }
                    else
                    {
                        DragonHP -= 100;
                        PlayerHP -= 40;
                        Console.WriteLine("\n" + "Вы украли 5% души дракона, тем самым нанесли 75 урона. Вы получили 40 урона. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                        Scream = false;
                        Still = true;
                    }
                }

                else if (skill == "Мясо Единорога" && PlayerHP <= 100)
                {
                    PlayerHP += 20;
                    Console.WriteLine("\n" + "Вас окружило защитным куполом и вы не получили урона. Также вы восстановили 20 единиц здоровья. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                }
                else if (skill == "Мясо Единорога" && PlayerHP >= 100)
                {
                    Console.WriteLine("\n" + "Вас окружило защитным куполом и вы не получили урона. Вы не восстановили здоровье. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                }
                else if (skill == "Удар Топором")
                {
                    if (Still == false)
                    {
                        PlayerHP -= 100;
                        Console.WriteLine("\n" + "Для начала нужно было Украсть Души! Удар не был нанесён! " +
                            "Вы получили 100 урона. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                    }
                    else
                    {
                        DragonHP -= 125;
                        PlayerHP -= 25;
                        Console.WriteLine("\n" + "Ваш удар нанес 125 урона. Вы получили 25 урона. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                        Still = false;
                    }
                }
                else if (skill == "Зов Богов")
                {
                    DragonHP -= 50;
                    PlayerHP -= 25;
                    Console.WriteLine("\n" + "Удар Молнии на 50 урона. Вы получили 25 урона. Ваше здоровье {0}. Здоровье дракона {1}", PlayerHP, DragonHP);
                }
                else
                {
                    Console.WriteLine("\n" + "Скилл не опознан. Попробуйте еще раз");
                }

            }

            if (PlayerHP <= 0)
            {
                Console.WriteLine("\n" + "Вы погибли!");
            }
            else
            {
                Console.WriteLine("\n" + "Вы выйграли! Поздравляю!");
            }
            Console.WriteLine("\n" + "Спасибо, что играли в нашу игру! Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
