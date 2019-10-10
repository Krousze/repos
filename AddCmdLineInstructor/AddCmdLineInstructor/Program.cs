using System;
class Program
{
    static void Main(string[] args)
    {
        int sum;

        Console.WriteLine("\n1. Using Convert.ToInt32() without exception handling.");
        sum = 0;
        foreach (string arg in args)
        {
            int intValue = Convert.ToInt32(arg); // arg string may not parse to an int!
            sum += intValue;
        }
        Console.WriteLine(sum);

        Console.WriteLine("\n2. Using Convert.ToInt32() with exception handling.");
        sum = 0;
        foreach (string arg in args)
        {
            try
            {
                int intValue = Convert.ToInt32(arg); // arg string may not parse to an int!
                sum += intValue;
            }
            catch
            {
                Console.WriteLine("arg " + arg + " could not be parsed to an int");
            }
        }
        Console.WriteLine(sum);

        Console.WriteLine("\n3. Using int.Parse() without exception handling.");
        sum = 0;
        foreach (string arg in args)
        {
            int intValue;
            intValue = int.Parse(arg);
            {
                sum += intValue;
            }
        }
        Console.WriteLine(sum);

        Console.WriteLine("\n4. Using int.Parse() with exception handling.");
        sum = 0;
        foreach (string arg in args)
        {
            int intValue;
            try
            {
                intValue = int.Parse(arg);
                {
                    sum += intValue;
                }
            }
            catch
            {
                Console.WriteLine("arg " + arg + " could not be parsed to an int");
            }
        }
        Console.WriteLine(sum);


        Console.WriteLine("\n5. Using int.TryParse() so no exception handling required!");
        sum = 0;
        foreach (string arg in args)
        {
            int intValue;
            if (int.TryParse(arg, out intValue))
            {
                sum += intValue;
            }
        }
        Console.WriteLine(sum);
    }
}
