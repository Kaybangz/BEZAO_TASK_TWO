using System;
using System.Collections.Generic;


namespace GuessingGameTask
{

    class RunGame
    {
        public int amountOfTries;

        public RunGame (int amountOfTries)
        {
            this.amountOfTries = amountOfTries;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //Make a secret number
            //Display a message if the user's guess is higher or lower than the secret number
            //Give the user a limited amount of tries
            //if the user guesses same number multiple times, count as one try
            RunGame rungame = new RunGame(5);
           
            
            Random randomNum = new Random();
            int secretNum = randomNum.Next(1, 20);

            //int numOfTries = 5;

            List<int> userGuesses = new List<int>();


            while (rungame.amountOfTries != 0)
            {
                Console.WriteLine("Guess the secret number:");

                int userGuess = Convert.ToInt32(Console.ReadLine());


                if (userGuess < secretNum )
                {
                    Console.WriteLine("Guess is smaller than secret number!");

                    userGuesses.Add(userGuess);

                    if (userGuesses.Count > 1)
            {
                if (userGuesses[userGuesses.Count - 1] != userGuesses[userGuesses.Count - 2])
                {
                   rungame.amountOfTries--;
                }
            }

                    
                    Console.WriteLine($"You have {rungame.amountOfTries} tries left");
                }

                else if (userGuess > secretNum)
                {
                    Console.WriteLine("Guess is bigger than secret number!\n");

                    userGuesses.Add(userGuess);

                    if (userGuesses.Count > 1)
            {
                if (userGuesses[userGuesses.Count - 1] != userGuesses[userGuesses.Count - 2])
                {
                   rungame.amountOfTries--;
                }
            }

                    Console.WriteLine($"You have {rungame.amountOfTries} tries left");
                }

                else if (userGuess == secretNum)
                {
                    Console.WriteLine("Congrats, You guessed the number correctly!");
                    break;
                }
                else
                {
                    Console.WriteLine("Input not recognized");
                }
            }


            


            if (rungame.amountOfTries == 0)
            {
                Console.WriteLine("You've run out of tries");
            }

            Console.ReadKey();
        }
    }
}