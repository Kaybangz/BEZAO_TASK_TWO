namespace PigLatinTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter text: ");

            string userText = Console.ReadLine();

            Console.WriteLine("Choose 'PL' to convert to pig latin and 'E' to convert to english ");

            string userChoice = Console.ReadLine();

            if (userChoice == "pl" || userChoice == "PL")
            {
                String[] newArr = userText.Split(" ");
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = newArr[i].Substring(1) + newArr[i].Substring(0, 1) + "ay";
                }

                Console.WriteLine(String.Join(" ", newArr));
            }
            else if (userChoice == "E" || userChoice == "e")
            {

                string[] newArr = userText.Split(" ");

                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = newArr[i][newArr[i].Length - 3] + newArr[i].Substring(0, newArr[i].Length - 3);
                }

            }
        }
    }
}