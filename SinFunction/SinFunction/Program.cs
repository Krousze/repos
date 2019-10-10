
using System;

namespace ConsoleSinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 400; i++)
            {
                double theta = i * (2 * Math.PI / 100);
                double sinTheta = Math.Sin(theta);
                int y = (int)(50 * (1 + sinTheta));
                Plot(y);
            }
        }

        static void Plot(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}