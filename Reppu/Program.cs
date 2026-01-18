using System.Drawing;

namespace Reppu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();

            

            while (true)
            {
                Console.WriteLine($"The bag currently has {bag.itemsInBag.Count.ToString()}/{bag.maxItemsInBag} items, " +
               $"{bag.currentWeight.ToString("F2")}/{bag.maxWeight} weight, " +
               $"and {bag.currentVolume.ToString("F2")}/{bag.maxVolume} volume.");

                Console.WriteLine("What would you like to add?");
                Console.WriteLine("1 - Arrow");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Rope");
                Console.WriteLine("4 - Water");
                Console.WriteLine("5 - Food");
                Console.WriteLine("6 - Sword");

                Item arrow = new Item(0.1f, 0.05f, "Arrow");
                Item bow = new Item(1f, 4f, "Bow");
                Item rope = new Item(1f, 1.5f, "Rope");
                Item water = new Item(2f, 2f, "Water");
                Item food = new Item(1f, 0.5f, "Food");
                Item sword = new Item(5f, 3f, "Sword");


                int chosedItemINT = 0;

                while (true)
                {
                    string chosenITEM = Console.ReadLine();
                    chosedItemINT = int.Parse(chosenITEM);


                    if (chosedItemINT >= 1 && chosedItemINT <= 6)
                    {
                        break;
                    }
                    Console.WriteLine("Chose an item from list with numbers");
                    Console.WriteLine(" ");

                    Console.WriteLine("What would you like to add?");
                    Console.WriteLine("1 - Arrow");
                    Console.WriteLine("2 - Bow");
                    Console.WriteLine("3 - Rope");
                    Console.WriteLine("4 - Water");
                    Console.WriteLine("5 - Food");
                    Console.WriteLine("6 - Sword");
                }

                if(chosedItemINT == 1)
                {
                    bag.addToBag(arrow);
                }

                if(chosedItemINT == 2)
                {
                    bag.addToBag(bow);
                }

                if(chosedItemINT == 3)
                {
                    bag.addToBag(rope);
                }

                if(chosedItemINT == 4)
                {
                    bag.addToBag(water);
                }

                if(chosedItemINT == 5)
                {
                    bag.addToBag(food);
                }

                if(chosedItemINT == 6)
                {
                    bag.addToBag(sword);
                }




            }

        }
    }

    public class Bag
    {
        public List<Item> itemsInBag = new List<Item>();

        public float maxItemsInBag = 10;

        public float maxWeight = 30;
        public float currentWeight = 0;

        public float maxVolume = 20;
        public float currentVolume = 0;

        public float leftWeight()
        {
            float leftWeight = maxWeight - currentWeight;


            return leftWeight;
        }
        public float leftVolume()
        {
            float leftVolume = maxVolume - currentVolume;


            return leftVolume;
        }

        public bool leftCount()
        {
            float leftCount = maxItemsInBag - itemsInBag.Count;

            if(leftCount!= 0)
            {
                return true;
            }
            else
                return false;

            
        }


        public void addToBag(Item item)
        {
            bool weightFit = leftWeight() > item.Weight;
            bool volumeFit = leftVolume() > item.Volume;

            if (leftCount())
            {
                if (weightFit && volumeFit)
                {
                    currentWeight = currentWeight + item.Weight;
                    currentVolume = currentVolume + item.Volume;
                    itemsInBag.Add(item);
                    Console.WriteLine( item.Name + " added");
                    Console.WriteLine(" ");

                }
                else if (weightFit && !volumeFit)
                {
                    Console.WriteLine("Only the weight fits; there is not enough volume.");
                }
                else if (!weightFit && volumeFit)
                {
                    Console.WriteLine("Only the volume fits; the weight limit is exceeded.");
                }
                else
                {
                    Console.WriteLine("Neither the weight nor the volume fits.");
                }
            }
            else
                Console.WriteLine("There is no space left."); Console.WriteLine(" ");






        }



    }
    public class Item
    {
        public string Name;
        public float Weight;
        public float Volume;

        public Item(float weight, float volume, string name)
        {
            Weight = weight;
            Volume = volume;
            Name = name;
        }


    }
}


