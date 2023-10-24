// Isaiah Reyes, Operators, v0.5
using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two string, interger, and float variables
            string wamp = ("Womp");
            string womp = ("Wamp");

            int Evelen = 11;
            int wha = 525600;

            float howDoWeMeasure = 45.69F;
            float aYearInTheLife = 35.68F;

            // Arithemtic Operators
            Console.WriteLine(Evelen - wha);
            //Console.WriteLine(wamp - womp); Does not Apply
            Console.WriteLine(howDoWeMeasure - aYearInTheLife);
            Console.WriteLine(Evelen - howDoWeMeasure);

            Console.WriteLine(Evelen / wha);
            //Console.WriteLine(wamp / womp); Does Not Apply
            Console.WriteLine(howDoWeMeasure / aYearInTheLife);
            Console.WriteLine(Evelen / howDoWeMeasure);

            Console.WriteLine(Evelen * wha);
            //Console.WriteLine(wamp * womp); Does Not Apply
            Console.WriteLine(howDoWeMeasure * aYearInTheLife);
            Console.WriteLine(Evelen * howDoWeMeasure);

            Console.WriteLine(Evelen + wha);
            Console.WriteLine(wamp + womp);
            Console.WriteLine(howDoWeMeasure + aYearInTheLife);
            Console.WriteLine(Evelen + howDoWeMeasure);

            // Modulous
            Console.WriteLine("Modulous");
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            // Increment
            int myInt2 = 1;
            myInt2++;
            Console.WriteLine(myInt2);

            // Decrement
            int myInt3 = 2;
            myInt3--;
            Console.WriteLine(myInt3);

            // Assignment Operators
            int boob = 2;
            boob += 3;
            boob -= 4;
            boob *= 18;
            boob /= 74;
            Console.WriteLine(boob);


            int booba = 7;
            int boobie = 69;
            int boobButBackwards = 96;
            int boobButForawrds = 69;
            // Comparason Operators
            Console.WriteLine(boob == myInt3);
            Console.WriteLine(booba > myInt2);
            Console.WriteLine(boobie >= myInt2);
            Console.WriteLine(boobButBackwards < Evelen);
            Console.WriteLine(boobButForawrds <= howDoWeMeasure);
            Console.WriteLine(boob != aYearInTheLife);

            //Logical Operators
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue && isFalse);  

            int wia = 5;  
            int woa = 3;  
            Console.WriteLine(wia | woa);

            int wiaa = 5;  
            Console.WriteLine(~wiaa);  

        }
    }
}
