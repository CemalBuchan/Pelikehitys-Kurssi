namespace Ruoka_annos
{
    internal class Program
    {
        public enum main { Chicken, Meat, Vegtables}
        public enum side { Potato, Rice, Pasta}
        public enum sauce { Curry, Chili, Tomato}


        static void Main(string[] args)
        {
            main mainDish = main.Chicken;
            Console.WriteLine("Chose your Food from menu with numbers in the menu");
            Console.WriteLine("Main dishes ( 1-Chicken, 2-Meat, 3-Vegtables )");
            string mainInt;
            string sideInt;
            string sauceInt;

            while (true)
            {
                mainInt = Console.ReadLine();

                if(mainInt == "1" || mainInt == "2" || mainInt == "3")
                    break;

                Console.WriteLine("Chose number from menu");

            }

            switch(mainInt)
            {
                case "1":
                    mainDish = main.Chicken;
                    break;
                case "2":
                    mainDish = main.Meat;
                    break;
                case "3":
                    mainDish = main.Vegtables;
                    break;

            }



            side sideDish = side.Potato;
            Console.WriteLine("Side dishes ( 1-Potato, 2-Rice, 3-Pasta )");

            while (true)
            {
                sideInt = Console.ReadLine();

                if (sideInt == "1" || sideInt == "2" || sideInt == "3")
                    break;

                Console.WriteLine("Chose number from menu");

            }

            switch (sideInt)
            {
                case "1":
                    sideDish = side.Potato;
                    break;
                case "2":
                    sideDish = side.Rice;
                    break;
                case "3":
                    sideDish = side.Pasta;
                    break;
            }

            sauce sauces = sauce.Curry;
            Console.WriteLine("Sauces ( 1-Curry, 2-Chilli, 3-Tomato )");


            while (true)
            {
                sauceInt = Console.ReadLine();

                if (sauceInt == "1" || sauceInt == "2" || sauceInt == "3")
                    break;

                Console.WriteLine("Chose number from menu");

            }


            switch (sauceInt)
            {
                case "1":
                    sauces = sauce.Curry;
                    break;
                case "2":
                    sauces = sauce.Chili;
                    break;
                case "3":
                    sauces = sauce.Tomato;
                    break;
            }

            Console.WriteLine(mainDish+ " and " +sideDish+ " with " +sauces);



        }
    }
}
