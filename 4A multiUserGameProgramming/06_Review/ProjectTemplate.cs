// Isaiah Reyes, Project Template, v0.1
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        
        static void Main(string[] args)
        {
            // Declaring and Assigning Variables
            // Interger -- -2,147,483,648 to 2,147,483,647
            // Interger = 4 bytes
            int yourMom = 10;

            // long -- -9,223,372,936,854,775,808 to 9,223,372,936,854,775,808
            // Long = 8 btyes
            long ayoQuestionMark = 12345678910111213;

            //Float -- Stores up to 6-7 Decimal digits
            //Float = 4 bytes
            float yourDad = 12.4F;

            // Double -- Stores up to 15 decimal points.
            //Double = 8 Bytes
            double trouble = 5.5002500600D;

            // Boolean -- True / false
            // Boolean = 1 bit
            bool yourGirlfriend = false;

            // String
            // 2-bytes PER CHARACTER
            // Must be in DOUBLE QOUTES "  "
            string yourDog = "Probably dead";
            string yourCat = "Ran away";

            // Character (char)
            // Single character, in SINGLE QOUTES ' '
            // 2 Bytes
            char yourGrade = 'F';

            // Type Casting -- Changing one data type to another
            // IMPLICIT -- Happens automatically wen going smaller -> Larger
            // char -> int -> long -> float ->  double

            int yourSister = 9000;
            double ohNvm = yourSister;
            Console.WriteLine(yourSister);

            // EXPLICIT -- Must be done manually when going larger -> smaller
            // double -> float -> long -> int -> char
            double dogs = 1.2345678910D;
            int noDogs = (int) dogs;
            
            // Conversion Methods
            Convert.ToString() // String
            Convert.ToDouble()  // Double
            Convert.ToInt32() // Integer
            Convert.ToInt64() // Long


            string intToString = Convert.ToString(noDogs);
            double stringToDouble = Convert.ToDouble(yourCat);
            int stringToInt = Convert.ToInt32(yourDog);
            long floatToLong = Convert.ToInt64(yourDad);

            // Switch Statment
            int dayOfWeek = 5;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("The day is sunday. \n");
                    break;
                case 2:
                    Console.WriteLine("The day is monday. \n");
                    break;
                case 3:
                    Console.WriteLine("The day is tuesday. \n");
                    break;
                case 4:
                    Console.WriteLine("The day is wednesday. \n");
                    break;
                case 5:
                    Console.WriteLine("The day is thursday. \n");
                    break;
                case 6:
                    Console.WriteLine("The day is friday. \n");
                    break;
                case 7:
                    Console.WriteLine("The day is saturday. \n");
                    break;    
                default:
                    Console.WriteLine("No match found. \n");
                    break;
            }



            
        }
    }
}
