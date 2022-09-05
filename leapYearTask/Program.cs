using System;

namespace LeapYearTask
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int year = 2022; year <= 2106; year++)
            {
                if (DateTime.IsLeapYear(year)){
                    Console.WriteLine("{0} is a leap year.", year);
                }
            }
            
        }
    }
}