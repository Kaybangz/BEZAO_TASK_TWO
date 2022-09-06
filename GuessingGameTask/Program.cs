using System;
using System.Collections.Generic;
namespace GuessingGameTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unsure whether or not the secret number should be a random number

            // int secretNumber = 344;
            Random generatedSecretNum = new Random();
            int secretNumber = generatedSecretNum.Next(1, 100);

            int numberOfTries = 5;

            //Empty list for inserting all of the user's guesses
            List<int> userTriesCollection = new List<int>();


            while (true)
            {
                //Print the message to the user
                Console.WriteLine("Guess the number(You have 5 tries):");

                //Collect input from user
                var userGuess = Convert.ToInt32(Console.ReadLine());


                //Check if user input is greater than, lesser than or equal to secret number
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Congratulations, you are correct!, the secret number is {secretNumber}");
                    break;

                }
                else if (userGuess >= secretNumber)
                {
                    Console.WriteLine("Your input is larger than secret number");

                    //Add user try to list
                    userTriesCollection.Add(userGuess);

                    //If user's current guess is similar to previous guess, count as 1 try
                    for (int i = 1; i <= userTriesCollection.Count; i++)
                    {

                        if (userTriesCollection[i] == userTriesCollection[i - 1])
                        {
                            Console.WriteLine($"You have {numberOfTries} tries left");
                        }
                        else
                        {
                            numberOfTries--;
                            Console.WriteLine($"You have {numberOfTries} tries left");
                        }
                    }


                }
                else if (userGuess <= secretNumber)
                {
                    Console.WriteLine("Your input is smaller than the secret number");

                    //Add user try to list
                    userTriesCollection.Add(userGuess);



                    //If user's current guess is similar to previous guess, count as 1 try
                    for (int i = 1; i <= userTriesCollection.Count; i++)
                    {

                        if (userTriesCollection[i] == userTriesCollection[i - 1])
                        {
                            Console.WriteLine($"You have {numberOfTries} tries left");
                        }
                        else
                        {
                            numberOfTries--;
                            Console.WriteLine($"You have {numberOfTries} tries left");
                        }
                    }
                }


                //Check if user has run out of chances
                if (numberOfTries == 0)
                {
                    Console.WriteLine("Sorry, you've run out of chances!");
                    break;
                }


                //Check if user wants to try again
                Console.WriteLine("Do you want to try again? (y/n):");
                var wantsToGuessAgain = Console.ReadLine();

                if (wantsToGuessAgain == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }



        }
    }
}