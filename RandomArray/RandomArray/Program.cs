using System;

namespace RandomArray
{
    class Program
    {
        static void Main()
        {
            int[,] intArray2D = new int[10, 20];
            Display(intArray2D);
            System.Random rnd = new Random();
            for (int i = 0; i < intArray2D.GetLength(0); i++)
            {
                for (int j = 0; j < intArray2D.GetLength(1); j++)
                {
                    intArray2D[i, j] = rnd.Next(0, 100);
                }
            }
            Console.WriteLine();
            Display(intArray2D);
        }

        private static void Display(int[,] intArray2D)
        {
            for (int i = 0; i < intArray2D.GetLength(0); i++)
            {
                for (int j = 0; j < intArray2D.GetLength(1); j++)
                {
                    Console.Write("{0,3:D1} ", intArray2D[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
