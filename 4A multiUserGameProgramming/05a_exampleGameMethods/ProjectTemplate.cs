// Isaiah Reyes, Captain, v0.1
using System;

namespace AlleyCats
{
    class Captain
    {
          // Variables
        int health; // Health of Captain, an integer variable
        float specialAttackCharge = 1.0f; // Charge level for special attack, a float variable
        string name = "Captain"; // Name of the character, a string variable
        bool isTeleporting = false; // State of teleporting, a boolean variable
        int[] telekinesisDamageValues = { 10, 20, 30 }; // Damage values for telekinesis attacks, an array variable
       
        // Using assignment operators
        public Captain()
        {
            health = 100; // using '=' assignment operator
            specialAttackCharge -= 0.1f; // using '-=' assignment operator
        }

        // Method with no return value
        // Teleports Captain to a new location
        public void Teleport()
        {
            pass; // Placeholder for the actual code
            // Logic for teleportation
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
            
        }
    }
}
