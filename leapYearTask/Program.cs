using System;

namespace LeapYearTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            int year = currentDate.Year;

            Console.WriteLine($"The next 20 leap years from {year} are: ");

            int count = 0;

            while (count < 20)
            {

                if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
                {
                    Console.WriteLine(year);
                    count++;
                }
                year++;
            }
        }
    }
}