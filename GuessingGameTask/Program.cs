using System;
namespace GuessingGameTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // int secretNumber = 344;
            Random generatedSecretNum = new Random();
            int secretNumber = generatedSecretNum.Next(1, 100);

            //Number of tries
            int numberOfTries = 5;


            while (true)
            {
                //Print the message to the user
                Console.WriteLine($"Guess the number between 1 and 100 \nYou have {numberOfTries} tries left: \n");

                //Collect input from user
                int userGuess = Convert.ToInt32(Console.ReadLine());

                //Check if user input is greater than, lesser than or equal to secret number
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Congratulations, you are correct!, the secret number is {secretNumber}\n");
                    break;
                }

                else if (userGuess >= secretNumber)
                {
                    Console.WriteLine("Guess is larger than secret number\n");
                    numberOfTries--;
                }

                else if (userGuess <= secretNumber)
                {
                    Console.WriteLine("Guess is smaller than the secret number\n");
                    numberOfTries--;
                }


                //Check if user has run out of chances
                if (numberOfTries == 0)
                {
                    Console.WriteLine("Sorry, you've run out of tries!");
                    break;
                }
            }

        }
    }
}