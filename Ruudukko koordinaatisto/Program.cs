using System.Diagnostics;
using System.Globalization;

namespace Ruudukko_koordinaatisto
{
    internal class Program
    {
        public struct Koordinaatti
        {
            public int X { get; private set; }
            public int Y { get; private set; }

            private Koordinaatti(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Koordinaatti Luo(Koordinaatti referans, int x, int y)
            {
                if (Math.Abs(referans.X - x) < 2 &&
                    Math.Abs(referans.Y - y) < 2)
                {

                    Console.WriteLine($"Coordinates are {x}, {y} thats next to 0, 0 ");

                    return new Koordinaatti(x, y);
                }
                else
                {
                    Console.WriteLine($"Coordinates are {x}, {y} thats not next to 0, 0 ");
                    return new Koordinaatti(x,y);
                }
            }
        }

        public static void luoRandomKoordinatti()
        {
            Random rnd = new Random();
            int RX = rnd.Next(-2, 2);
            int RY = rnd.Next(-2, 2);

            Koordinaatti.Luo(new Koordinaatti(),RX, RY);
        }



        static void Main(string[] args) 
        {
            for (int i = 0; i < 10; i++)
            {
                luoRandomKoordinatti();
            }
            

        }
    }
}
