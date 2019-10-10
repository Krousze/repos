using System;


namespace EnumerationMonthsOfTheYear
{
    public enum Month { January = 1, February, March, April, May, June, July, August, September, October, November, December };
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a number between 1 and 12"); //Gives beginning instruction
            String NumberOfMonth = Console.ReadLine();
            int MonthNumber;
            while (!int.TryParse(NumberOfMonth, out MonthNumber )) // This section loop checks for a proper input
            {
                Console.Write("Input is invalid Pick only whole numbers 1 through 12\n"); //This output is to tell what is needed to continue
                NumberOfMonth = Console.ReadLine();
            }
            if (MonthNumber > 0 && MonthNumber <= 12)
            {
                Month month = (Month)MonthNumber;
                Console.WriteLine(month);
            }
            Console.ReadKey();
        }
    }
}
