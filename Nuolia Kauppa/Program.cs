using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Nuolia_Kauppa
{

    public enum arrowTIPS { Diamond, Steel, Wood }
    public enum arrowENDS { Leaf, ChickenFeather, EagleFeather }

    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to my arrow shop");
                Console.WriteLine("What do you want to do");
                Console.WriteLine(" ");

                Console.WriteLine("1 - To make arrow");

                int cPInt;

                while (true)
                {
                    string chosenPurpose = Console.ReadLine();
                    cPInt = int.Parse(chosenPurpose);


                    if (cPInt == 1)
                    {
                        break;
                    }
                    Console.WriteLine("I dont have any service like that");
                    Console.WriteLine("What do you want to do");
                    Console.WriteLine(" ");

                    Console.WriteLine("1 - To make arrow");
                }

                arrowTIPS chosedTIP = arrowTIPS.Wood;
                arrowENDS chosedEND = arrowENDS.Leaf;

                int length = 0;






                Console.WriteLine("You chose to make your arrow");
                Console.WriteLine(" ");




                Console.WriteLine("How do you want your arrows tip");
                Console.WriteLine("{1- Diamond, 2- Steel, 3- Wood }");

                int cTInt;

                while (true)
                {
                    string chosenTip = Console.ReadLine();
                    cTInt = int.Parse(chosenTip);

                    if (cTInt == 1 || cTInt == 2 || cTInt == 3)
                    {
                        break;
                    }
                    Console.WriteLine("Choose something that i have");
                    Console.WriteLine("{1- Diamond, 2- Steel, 3- Wood }");
                }

                switch (cTInt)
                {
                    case 1:
                        Console.WriteLine("Your arrows tip is Diamond");
                        chosedTIP = arrowTIPS.Diamond;
                        break;

                    case 2:
                        Console.WriteLine("Your arrows tip is Steel");
                        chosedTIP = arrowTIPS.Steel;

                        break;

                    case 3:
                        Console.WriteLine("Your arrows tip is Wood");
                        chosedTIP = arrowTIPS.Wood;

                        break;
                }

                Console.WriteLine(" ");




                Console.WriteLine("How do you want your arrows End");
                Console.WriteLine("{1- Eagle feather, 2- Chicken feather, 3- Leaf }");


                int cEInt;

                while (true)
                        {
                            string chosenEND = Console.ReadLine();
                            cEInt = int.Parse(chosenEND);

                            if (cEInt == 1 || cEInt == 2 || cEInt == 3)
                            {
                                break;
                            }
                            Console.WriteLine("Choose something that i have");
                            Console.WriteLine("{1- Eagle feather, 2- Chicken feather, 3- Leaf }");
                            Console.WriteLine(" ");

                        }

                switch (cEInt)
                {
                    case 1:
                        Console.WriteLine("Your arrows End is Eagle feather");
                        chosedEND = arrowENDS.EagleFeather;
                        break;

                    case 2:
                        Console.WriteLine("Your arrows End is Chicken feather");
                        chosedEND = arrowENDS.ChickenFeather;

                        break;

                    case 3:
                        Console.WriteLine("Your arrows End is Leaf");
                        chosedEND = arrowENDS.Leaf;

                        break;
                }
                Console.WriteLine(" ");





                Console.WriteLine("How long do you want your arrow to be (60-100)cm");

                int arrowLenght;

                while (true)
                {
                    string chosenLenght = Console.ReadLine();
                    arrowLenght = int.Parse(chosenLenght);

                    if (arrowLenght < 101 && arrowLenght > 59)
                    {
                        Console.WriteLine("Your arrows lenghts is " + arrowLenght + " cm");
                        length= arrowLenght;
                        break;
                    }
                    Console.WriteLine("Choose a lenght that i can do");
                    Console.WriteLine("(60 to 100)");
                    Console.WriteLine(" ");

                }

                Console.WriteLine(" ");

                Arrow arrow = new Arrow(chosedTIP, chosedEND, length);

                Console.WriteLine("Your arrow choses");
                Console.WriteLine("Tip : " + arrow.Tips.ToString());
                Console.WriteLine("End : " + arrow.Ends.ToString());
                Console.WriteLine("Lenght : " + arrow.Lenght);
                Console.WriteLine(" ");
                Console.WriteLine("Price : " + arrow.getArrowPrice().ToString());

                Console.WriteLine("Do you want to do something else ");
                Console.WriteLine("1- Yes ");
                Console.WriteLine("2- No ");

                int cWInt;

                while (true)
                {
                    string chosenTip = Console.ReadLine();
                    cWInt = int.Parse(chosenTip);

                    if (cWInt == 1 || cWInt == 2)
                    {
                        break;
                    }
                    Console.WriteLine("You dont have that option ");

                }
                Console.WriteLine(" ");
                

                if (cWInt == 2)
                {
                    break;
                }
            }
        }
    }


    public class Arrow
    {
        public arrowTIPS Tips { get; private set; }
        public arrowENDS Ends { get; private set; }

        public int Lenght;

        public Arrow (arrowTIPS TIPS, arrowENDS ENDS, int LENGHT)
        {
            Tips = TIPS;
            Ends = ENDS;
            Lenght = LENGHT;
        }

        public float getArrowPrice()
        {
            float arrowPRICE = 0;


            switch (Tips)
            {
                case arrowTIPS.Diamond:
                    arrowPRICE = arrowPRICE + 50;
                    break;

                case arrowTIPS.Steel:
                    arrowPRICE = arrowPRICE + 5;
                    break;

                case arrowTIPS.Wood:
                    arrowPRICE = arrowPRICE + 4;
                    break;
            }

            switch (Ends)
            {
                case arrowENDS.EagleFeather:
                    arrowPRICE = arrowPRICE + 5;
                    break;

                case arrowENDS.ChickenFeather:
                    arrowPRICE = arrowPRICE + 1;
                    break;

                case arrowENDS.Leaf:
                    arrowPRICE = arrowPRICE + 0;
                    break;
            }

            float lenghtPrice = Lenght * 0.05f;
            arrowPRICE = arrowPRICE + lenghtPrice;

            return arrowPRICE;
        }

       
    }

}
