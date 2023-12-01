// Isaiah Reyes, Captain, v0.2
using System;

namespace TextAdventureGame
{
    class AdventureGame
    {
        public void Teleport()
        {
        }

        static void Methodtwo()
        {

        }

        static RETURNTYPE MethodThree()
        {

        }

        static RETURNTYPE MethodFour()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text Adventure Game!");
            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Explore");
                Console.WriteLine("2. Check Inventory");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Exit Game");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Explore();
                        break;
                    case "2":
                        CheckInventory();
                        break;
                    case "3":
                        Rest();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for playing!");
                        return;
                    default:
                        Console.WriteLine("Invalid action. Please choose again.");
                        break;
                }
            }
        }
    }
}
