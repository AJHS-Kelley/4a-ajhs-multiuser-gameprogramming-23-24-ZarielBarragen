// Isaiah Reyes, Control Flow, v0.4
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
            // DECLARATIONS
            string favColor = "Pink";
            int luckyNumber = 69;
            float myGPA = 3.7F;
            int myAge = 17;
            bool pineappleOnPizza = false;

            // if Statment -- Check for a single condition
            if (favColor == Yellow)
            {
                Console.WriteLine("Mellow Yellow");
            }

            if (int luckyNumber == 69 )
            {
                Console.WriteLine("nice.");
            }

            // if - else Statement -- Checks for a single condition, but has two actions.
            if (myAge > 15)
            {
                Console.WriteLine("You are eligible to drive.");
            }
            else
            {
                Console.WriteLine("Back on your feet, loser.");
            }

            // if -- else if -- else -- Checks multiple outcomes.
            if(myGPA == 4.0F)
            {
                Console.WriteLine("You got all A's, baby!");
            }
            else if(myGPA >= 3.0F)
            {
                Console.WriteLine("A's and B's are okay too!");
            }
            else if(myGPA >= 2.0F)
            {
                Console.Writeline("You're just barely there, kiddo.");
            }

            // Nested Statments
            if (pineappleOnPizza == true) 
            {
                Console.WriteLine("Ew, thats disgusting, you must be old.");
                if (myAge > 60) 
                {
                    Console.WriteLine("Yeah, I knew it.");
                }
                else
                {
                    Console.WriteLine("Oh so you're just weird.");
                }
            else
            {
                Console.WriteLine("Glad to see you're sane.");
            }

            // for loop -- Best for when you know # of iterations needed.
            /*
            
            for (statment1; statment2; statment3)
            {
                Code to loop
            }
            statment1 is executed ONCE BEFORE the loop starts.
            statment2 is a CONDITIONAL  that is checked EVERYTIME BEFORE the loop starts
            statment3 is executed EVERYTIME after the loop executes.
            

            for(int i = 0; i < 101; i++)
            {
                Console.WriteLine("" + i);
            }

            //Create your own loop that counts down from 100 to 0
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine("" + i);
            }

            // Nested Loops
            //Outer Loop
            for(int i = 1; i <=2; i++)
            {
              Console.WriteLine("Outer;" + i);   

              for(int j = 1; j <= 3; j++)
              {
                Console.WriteLine("Inner:" + j);
              }
            }

            //While loop - Best used when # of interations needed is unknown
            int x = 0;
            while(x < 1000)
            {
                Console.WriteLine("" + x);
                x++;
            }
            */

            // Special Keywords
            // break will immediately exit a LOOP or an IF/ELSE IF/ELSE block
            for(int i = 0; i < 101; i++)
            {
                Console.Writeline("" + i);
                if (i == 50) 
                {
                    break;
                }
            }

            // continue will SKIP the current iteration and then finish the loop.
             for(int i = 0; i < 101; i++)
            {   if (i == 50) 
                {
                    continue;
                }
                Console.Writeline("" + i);
                
            }

        }           
    }
}
