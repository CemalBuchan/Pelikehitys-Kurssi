using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Ovi
{
    internal class Program
    {
        public enum doorState {Opened, Closed, Locked}
       // it will be easyer if i use switch but why not "if" :)
        static void Main(string[] args)
        {
            doorState state = doorState.Opened;
            
            Console.WriteLine("You can open, close, lock, unlock");
            while (true)
            {
                Console.WriteLine("Door Is "+state);
                Console.Write("what do you want to do  ");
                string Want = Console.ReadLine();


                if (state == doorState.Opened && Want == "close")
                {
                    state = doorState.Closed;
                }
                else if(state == doorState.Opened && Want != "close")
                {
                    Console.WriteLine("You cant do it");
                }


                else if(state == doorState.Closed && Want == "open")
                {
                    state = doorState.Opened;
                }
                else if(state == doorState.Closed && Want == "lock")
                {
                    state = doorState.Locked;
                }
                else if (state == doorState.Closed && Want == "close")
                {
                    Console.WriteLine("You cant do it");
                } 


                else if(state == doorState.Locked && Want == "unlock")
                {
                    state=doorState.Closed;
                }
                else if( state == doorState.Locked && Want != "unlock")
                {
                    Console.WriteLine("You cant do it");
                }


                else if (Want != "close" || Want != "open" || Want != "lock")
                {
                    Console.WriteLine("You cant do it");
                }

            }
        }
    }
}
