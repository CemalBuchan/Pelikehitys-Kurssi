namespace Robotti
{       //Sain tehtävän suoritettua tekoälyn avulla.
        //Avun saamisen jälkeen se helpottui.

        public interface  RobottiKäsky
        {
            public abstract void Suorita(Robotti robotti);
        }



        public class Käynnistä : RobottiKäsky
        {
            public  void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = true;
            }
        }

        public class Sammuta : RobottiKäsky
        {
            public  void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = false;
            }
        }

        public class YlösKäsky : RobottiKäsky
        {
            public  void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                    robotti.Y += 1;
            }
        }

        public class AlasKäsky : RobottiKäsky
        {
            public  void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                    robotti.Y -= 1;
            }
        }

        public class VasenKäsky : RobottiKäsky
        {
            public  void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                    robotti.X -= 1;
            }
        }

        public class OikeaKäsky : RobottiKäsky
        {
            public  void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                    robotti.X += 1;
            }
        }


        public class Robotti
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool OnKäynnissä { get; set; }
            public RobottiKäsky?[] Käskyt { get; } = new RobottiKäsky?[3];

            public void Suorita()
            {
                foreach (RobottiKäsky? käsky in Käskyt)
                {
                    käsky?.Suorita(this);
                    Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
                }
            }
        }

    class Program
    {
        static void Main()
        {
            Robotti robotti = new Robotti();

            Console.WriteLine("Komentoja:");
            Console.WriteLine("kaynnista, sammuta, ylos, alas, vasen, oikea");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Koment {i + 1}: ");
                string? input = Console.ReadLine()?.ToLower();

                robotti.Käskyt[i] = input switch
                {
                    "kaynnista" => new Käynnistä(),
                    "sammuta" => new Sammuta(),
                    "ylos" => new YlösKäsky(),
                    "alas" => new AlasKäsky(),
                    "vasen" => new VasenKäsky(),
                    "oikea" => new OikeaKäsky(),
                    _ => null
                };
            }

            Console.WriteLine(" ");
            robotti.Suorita();
        }
    }
}
