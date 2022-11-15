using System.Collections.Generic;

namespace NumbersInWords
{
    String ones(string num)
    {
        int number_holder = Convert.ToInt32(num);
        string? number_value = null;

        switch (number_holder)
        {
            case 1:
                number_value = "One";
                break;
            case 2:
                number_value = "Two";
                break;
            case 3:
                number_value = "Three";
                break;
            case 4:
                number_value = "Four";
                break;
            case 5:
                number_value = "Five";
                break;
            case 6:
                number_value = "Six";
                break;
            case 7:
                number_value = "Seven";
                break;
            case 8:
                number_value = "Eight";
                break;
            case 9:
                number_value = "Nine";
                break;
        }

        return number_value;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}