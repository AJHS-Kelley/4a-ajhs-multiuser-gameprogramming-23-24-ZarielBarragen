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
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save whatever gets typed to a STRING by default
            Console.WriteLine("You have selected " + difficulty);
            if(difficulty == "Easy")
            {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 5;
            }            
            else if (difficulty == "Normal")
            {
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
            }

            else if (difficulty == "Hard")
            {
                rangeMin = 0;
                rangeMax = 100;
                numGuesses = 3;
            }
            else 
            {
                Console.WriteLine("You didnt pick anything, goofy");
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numGuesses);

            // Start the Match
            while (playerScore != 3 && cpuScore != 3)
            {
                // Any code you run want to run BEFORE each round goes here.
                // Generate Secret Number
                Random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMax, rangeMin);
                Console.WriteLine("Player Score: " + playerScore + "\n");
                Console.WriteLine("CPU Score: " + cpuScore + "\n");

                // Start each round
                for (int i = 0; i < numGuesses; i++)
                {
                    Console.WriteLine(" You have used " + numAttempts + " this round. \n");
                    Console.WriteLine("You must guess between " + rangeMin + "and " + rangeMax + ". \n");

                    Console.WriteLine("Guess a number:");
                    int guess = System.Convert.ToInt32(Console.ReadLine());

                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Congratulations! You've guessed correctly.");
                        playerScore++;
                        break; 
                        // Exit the loop if guessed correctly
                    }

                    else
                    {
                        if (guess < secretNumber)
                        {
                            Console.WriteLine("Your guess is too low.");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is too high.");
                        }
                     numAttempts++;

                    if (i == numGuesses - 1)
                    {
                        Console.WriteLine("You've run out of guesses! CPU wins this round.");
                        cpuScore++;
                    }
                    } 
                }
            }
            if (playerScore >= 3)
            {
                Console.WriteLine("You've won the game!");
            }
            else
            {
                Console.WriteLine("You have lickity lost this game!");
            }
        }
    }
}
    
