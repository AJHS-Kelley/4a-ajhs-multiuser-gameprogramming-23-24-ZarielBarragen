// Isaiah Reyes, Number Guess, v0.3
/*
Generate a secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print game instructions including range and num. of guesses allowed
    Match == first player to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on
Ask the player what number would they like to guess
Determine if the guess is correct or not
    If guess is correct
    {
        Tell them they have guessed correctly
        Award the player a point.
    }
    else
    {
        Tell them they are wrong
        Tell player if guess is too high or too low
        Check to see if they have guesses remaining
        {
            if guess remain
            {
                allow player to guess again
            }
            else
            {
                CPU wins the round
            }
        }
    }




*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;;
            int numGuesses = 0; //Number of Guesses ALLOWED
            int numAttempts = 0; //Number of guesses TAKEN
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMax = -1;
            int rangeMin = -1;

            Console.WriteLine("Hi. This is a number guessing game. \n You will play. \n Or die. \n Select how hard the game will be. \n");
            Console.WriteLine("Easy: Range is 0 - 10 with 5 guesses. \n Normal is 0-25 with 4 guesses. \n Hard is 0-100 with 3 guesses.\n");

            // Difficuly Selection
            Console.WriteLine("Please enter Easy, Normal, or Hard and press ENTER");
            difficulty = Console.Readline();
            // Console.ReadLine() will save whatever gets typed to a STRING by default
            Console.WriteLine("You have selected " + difficulty);
            if(difficulty == "Easy")
            {
                rangeMax = 0;
                rangeMin = 10;
                numGuesses = 5;
            }            
            else if ("Normal")
            {
                rangeMax = 0;
                rangeMin = 25;
                numGuesses = 4;
            }

            else if ("Hard")
            {
                rangeMax = 0;
                rangeMin = 100;
                numGuesses = 3;
            }
            else 
            {
                Console.WriteLine("You didnt pick anything, goofy");
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.Writeline("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numGuesses);

            // Start the Match
            while (playerScore != 3 && cpuScore != 3)
            {
                secretNumber = rnd.Next(rangeMin, rangeMax + 1);

                // Start each round
                for (int i = 0; i < numGuesses; i++)
                {
                    Console.WriteLine("Guess a number:");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Congratulations! You've guessed correctly.");
                        playerScore++;
                        break; // Exit the loop if guessed correctly
                    }

                    else
                    {
                        if (guess < secretNumber)
                            Console.WriteLine("Your guess is too low.");
                        else
                            Console.WriteLine("Your guess is too high.");

                        if (i == numGuesses - 1)
                        {
                            Console.WriteLine("You've run out of guesses! CPU wins this round.");
                            cpuScore++;
                        }

                    }                   
        }
    }
}