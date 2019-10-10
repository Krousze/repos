using System;

namespace ReversingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int[] numbers = GenerateNumbers()
            Array();
        }
    
        public static void Array()
        {
            int[] numbers = new[] {};
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            ReverseArray(numbers);
        }

        public static void ReverseArray(int[] numbers)
        {
            System.Array.Reverse(numbers);

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}