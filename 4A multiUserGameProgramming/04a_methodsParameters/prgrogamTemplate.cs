// Isaiah Reyes, MethodsParameters, v0.5
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // Method -- Named block of code, can be used over and over
        // All methods have a signature that defines their name, parameters, and output.
        // Example signature
        static void MyMethod()
        {
            Console.WriteLine("Four big guys. \n");
        }

        // static -- This method belongs to the current class, it is NOT an object
        // void -- This method has no return value

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it. \n");
            Console.WriteLine("Please enter a number on the next line. \n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }

        // Method with Parameters
        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Bacon Pancakes. \n");
            }
        }
        static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have ordered" + num + "eggs cooked" + style + ".\n" );
        }

        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am about to cook " + num + " hamburgers, \n");
        }


        //Named Arguments
        static void AllMyFellas(string fella1, string fella2, string fella3)
        {
            Console.WriteLine("A-A-All my fellas " + fella3);
        }

        
        
        //Method Overloading
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }


        //Find sum of Double
        static double FindSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }
        
        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes(10);
            //MakeEgss(10, "sunny side up");
            //MakeBurger();
            //MakeBurger(10);
            //AllMyFellas(fella3: "*piano noises*", fella2: "*do do do do do*", fella1: "dun da da dun dun dun");
            FindSum(1, 5);
            FindSum(9.5, 2.4);
            FindSum(5, 2.5);
        }
    }
}
