using System.Security.AccessControl;

namespace Knight_Ork
{
    internal class Program
    {
        

        static void Main()
        {

            int KnightHealth = 15;
            int OrkHealth = 15;
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("You met with ork at forest");
            Console.ResetColor();

            while (KnightHealth > 0 && OrkHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("---------------------------------");
                Console.ResetColor();

                Console.WriteLine(" ");

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Knight(you) ");

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.Write(KnightHealth + " /15");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("  Ork ");
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine(OrkHealth + " /15");
                Console.ResetColor();

                Console.WriteLine(" ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What do you want to do");
                Console.WriteLine(" ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1-Attack the ork with sword");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("2-Defend the attack with shield");
                Console.ResetColor();


                int vastaus = int.Parse(Console.ReadLine());

                if (vastaus == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You attacked the Ork with sword");
                    Console.ResetColor();

                    int damage = random.Next(2, 6);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine("You dealed " + damage + " damage");
                    Console.ResetColor();

                    OrkHealth = OrkHealth - damage;
                    Console.WriteLine(" ");

                    int orkdamage = random.Next(2, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ork attacked you with sword");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Ork dealed " + orkdamage + " damage");
                    Console.ResetColor();

                    KnightHealth = KnightHealth - orkdamage;

                }
                else if (vastaus == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("You defended the Ork with shield");
                    Console.ResetColor();

                    int orkdamage = random.Next(2, 6);
                    orkdamage = orkdamage / 2;
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Ork dealed " + orkdamage + " damage");
                    Console.ResetColor();

                    KnightHealth = KnightHealth - orkdamage;
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
