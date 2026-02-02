namespace Väritetyt_tavarat
{

    public class Tavara { }

    public class Miekka : Tavara { }

    public class Kirves : Tavara { }
    public class Juosi : Tavara { }

    public class VaritettyTavara<T> where T : Tavara
    {
        public T Tavara { get; set; }
        public ConsoleColor Vari { get; set; }

        public VaritettyTavara(T tavara, ConsoleColor vari)
        {
            Tavara = tavara;
            Vari = vari;
        }

        public void NaytaTavara()
        {
            ConsoleColor alkuVari = Console.ForegroundColor;
            Console.ForegroundColor = Vari;
            Console.WriteLine(Tavara.GetType().Name);
            Console.ForegroundColor = alkuVari;
        }
    }

    // Örnek kullanım
    class Program
    {
        static void Main()
        {

            Miekka testiMiekka = new Miekka();
            Kirves testiKirves = new Kirves();
            Juosi testiJuosi = new Juosi();

            VaritettyTavara<Miekka> tulimiekka = new VaritettyTavara<Miekka>(testiMiekka, ConsoleColor.Red);
            VaritettyTavara<Kirves> vihreaKirves = new VaritettyTavara<Kirves>(testiKirves, ConsoleColor.Green);
            VaritettyTavara<Juosi> sininenJousi = new VaritettyTavara<Juosi>(testiJuosi, ConsoleColor.Blue);

            tulimiekka.NaytaTavara();
            vihreaKirves.NaytaTavara();
            sininenJousi.NaytaTavara();
        }
    }

}
