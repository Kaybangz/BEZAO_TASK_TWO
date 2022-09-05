namespace GuessingGameTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 344;
            int numberOfTries = 5;


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
                    numberOfTries--;
                    Console.WriteLine($"You have {numberOfTries} tries left");
                }
                else if (userGuess <= secretNumber)
                {
                    Console.WriteLine("Your input is smaller than the secret number");
                    numberOfTries--;
                    Console.WriteLine($"You have {numberOfTries} tries left");
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