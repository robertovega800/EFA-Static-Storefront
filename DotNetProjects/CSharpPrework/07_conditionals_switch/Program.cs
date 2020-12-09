using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name");
            string inputName = Console.ReadLine().ToLower();

            //2
            switch (inputName)
            {
                //3
                case "fred": //Same as checking: if (inputName =="fred")

                    Console.WriteLine(" Hey Fred, let's go golfing.");
                    //4
                    break;
                case "Karl": // Same as checking: else if (inputName =="Karl")

                    Console.WriteLine("Let's Hang.");
                    break;
                case "john": // Same as checking: else if (inputName == "john")

                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default: // Same as: else

                    Console.WriteLine("Hey" + inputName + ", can I call you back in a minut?");
                    break; // This break is required
            }
            //5
            {
                Console.WriteLine("What's your friend's name?");
                string friend = Console.ReadLine().ToLower();

                switch (friend)
                {
                    case "Jess":
                        Console.WriteLine("Jess is very insightful!");
                        break;
                    case "Sami":
                        Console.WriteLine("Sami is hilarious!");
                        break;
                          case "Dylan":
                        Console.WriteLine("Dylan is an amazing middle school teacher!");
                        break;
                    default:
                        Console.WriteLine($"I don't know{friend}.");

                        break;
                        
                }
            }
            Console.ReadLine();
        }
    }
}
