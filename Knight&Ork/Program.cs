using System;
using System.Security.AccessControl;

namespace Knight_Ork
{
    internal class Program
    {
        static void writeStatus(int knightHealth, int orkHealth)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---------------------------------");
            Console.ResetColor();

            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Knight(you) ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Write(knightHealth + " /15");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("  Ork ");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(orkHealth + " /15");
            Console.ResetColor();

            Console.WriteLine(" ");
        }

        static void askWhatToDo()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What do you want to do");
            Console.WriteLine(" ");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1-Attack the ork with sword");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("2-Defend the attack with shield");
            Console.ResetColor();

        }

        static void attack(ref int knightHealth, ref int orkHealth)
        {
            Random rnd = new Random();
            int damage = rnd.Next(2, 6);
            Console.WriteLine($"You dealed {damage} damage");
            orkHealth -= damage;

            int orkdamage = rnd.Next(2, 6);
            Console.WriteLine($"Ork dealed {orkdamage} damage");
            knightHealth -= orkdamage;
        }

        static void defend(ref int knightHealth, ref int orkHealth)
        {
            Random rnd = new Random();
            int orkdamage = rnd.Next(2, 6) / 2;
            Console.WriteLine($"Ork dealed {orkdamage} damage");
            knightHealth -= orkdamage;
        }

        static void Main()
        {

            int KnightHealth = 15;
            int OrkHealth = 15;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("You met with ork at forest");
            Console.ResetColor();

            while (KnightHealth > 0 && OrkHealth > 0)
            {
               
                writeStatus(KnightHealth, OrkHealth);

                askWhatToDo();

                int vastaus = int.Parse(Console.ReadLine());

                if (vastaus == 1)
                {
                    attack(ref KnightHealth, ref OrkHealth);
                }
                else if (vastaus == 2)
                {
                    defend(ref KnightHealth, ref OrkHealth);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("I didnt understand");
                    Console.ResetColor();
                }

            }
            bool bothDied = false;

            if (KnightHealth <= 0 && OrkHealth <= 0)
            {
                bothDied = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("YOU BOTH DIED");
            }
            else if (KnightHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("You Defeated");
            }
            else if (OrkHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You killed the ork");
            }

            Console.ResetColor();
        }

        

    }
}
