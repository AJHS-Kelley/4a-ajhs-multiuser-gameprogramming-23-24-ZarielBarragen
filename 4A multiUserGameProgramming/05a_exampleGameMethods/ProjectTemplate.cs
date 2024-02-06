// Isaiah Reyes, Captain, v0.8
using System;
using System.Collections.Generic;

namespace TextAdventureGame
{
    class AdventureGame
    {
        public int Health { get; private set; }
        public TimeSpan TimeSpent { get; private set; }
        private static List<string> inventory = new List<string> { "Map", "Rope" };
        private static Player player = new Player()

        public void Player()
        {
            // Start the player with full health and no time spent
            Health = 100;
            TimeSpent = TimeSpan.Zero;
        }
        
        // Method for the explore action
        static void Explore()
        {
            Console.WriteLine("You explore the ancient ruins and find a treasure chest!");

            // Random chance of finding an item
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 1) // 50% chance
            {
                Console.WriteLine("Inside the chest, you find a golden amulet!");
                inventory.Add("Golden Amulet");
            }
            else
            {
                Console.WriteLine("The chest is empty. Better luck next time.");
            }
        }

         static void CheckInventory()
        {
            Console.WriteLine("You check your backpack.");

            // Display items in the inventory
            if (inventory.Count == 0)
            {
                Console.WriteLine("Your backpack is empty.");
            }
            else
            {
                foreach (string item in inventory)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }

         // Method to simulate resting
        public void Rest()
        {
            // Assume each rest heals 10 points up to the maximum of 100, and takes 1 hour
            Health = Math.Min(Health + 10, 100);
            TimeSpent = TimeSpent.Add(TimeSpan.FromHours(1));
        }

        static void Rest()
        {
            player.Rest(); // Rest method on the player object
            Console.WriteLine($"You rest for a while. Health is now {player.Health}.");
            Console.WriteLine($"Time spent resting: {player.TimeSpent.Hours} hours.");
        }

        // Additional method for searching for food
         static string SearchForFood()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 1) // 50% chance
            {
                AdventureGame.inventory.Add("Food"); // Access static member with class name
                return "You found some food and added it to your backpack!";
            }
            else
            {
                return "You searched for food but found nothing.";
            }
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
                Console.WriteLine("5. Search for Food");
                
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
                    case "5":
                        string searchResult = SearchForFood();
                        Console.WriteLine(searchResult);
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please choose again.");
                        break;
                }
            }
        }
    }
}

// Code Review by Xavier Oliver