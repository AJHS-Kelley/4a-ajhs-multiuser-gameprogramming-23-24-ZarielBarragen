// Isaiah Reyes, Captain, v0.3
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

            // Game loop that continues until the player chooses to exit
            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Explore");
                Console.WriteLine("2. Check Inventory");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Exit Game");
                
                // Read player's input
                string userInput = Console.ReadLine();

                // Handle player's action based on input
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
                        return; // Exit the game loop and end the program
                    default:
                        Console.WriteLine("Invalid action. Please choose again.");
                        break;
                }
            }
        }
    }
}
