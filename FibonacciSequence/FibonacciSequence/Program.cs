using System;

namespace FibonacciSequence
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter position on the Fibonacci sequence you wish to know");
            ulong number = Convert.ToUInt64(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
        }

        public static void Fibonacci(ulong a, ulong b, ulong i, ulong number)
        {
            Console.WriteLine(a);
            if (i < number) Fibonacci(b, a + b, i + 1, number);
        }
    }
}