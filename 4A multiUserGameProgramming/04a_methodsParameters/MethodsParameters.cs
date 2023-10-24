// Isaiah Reyes, MethodsParameters, v0.2
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

        static int DoubleUp():
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it. \n");
            Console.WriteLine("Please enter a number on the next line. \n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return 0;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
