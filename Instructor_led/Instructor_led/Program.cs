using System;


namespace Instructor_led
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(0.2 + 0.5 == 0.7); // True
            Console.WriteLine(0.1 + 0.2 == 0.3); // False

            Console.WriteLine();

            Console.WriteLine(Math.Pow(2, 3));           // 8
            Console.WriteLine(Math.Pow(2, 3).GetType()); // System.Double
            Console.WriteLine(sizeof(int));              // 4
            Console.WriteLine(int.MaxValue);             // 2147483647
            Console.WriteLine(int.MinValue);             // -2147483648
            Console.WriteLine((int)Math.Pow(2, 31) - 1); // 2147483647
            Console.WriteLine((int)Math.Pow(2, 31));     // -2147483648

            Console.WriteLine();

            Console.WriteLine(0b0000_0000_0000_0000_0000_0000_0000_0000);           // 0
            Console.WriteLine(0b0000_0000_0000_0000_0000_0000_0000_0001);           // 1
            Console.WriteLine(0b1000_0000_0000_0000_0000_0000_0000_0000);           // 2147483648
            Console.WriteLine(0b1111_1111_1111_1111_1111_1111_1111_1111);           // 4294967295
            Console.WriteLine(0b1111_1111_1111_1111_1111_1111_1111_1111.GetType()); // System.UInt32

            Console.WriteLine();

            unchecked // needed to disable narrowing type conversion error
            {
                Console.WriteLine((int)0b0000_0000_0000_0000_0000_0000_0000_0000);             // 0
                Console.WriteLine((int)0b0000_0000_0000_0000_0000_0000_0000_0001);             // 1
                Console.WriteLine((int)0b1000_0000_0000_0000_0000_0000_0000_0000);             // -2147483648
                Console.WriteLine((int)0b1111_1111_1111_1111_1111_1111_1111_1111);             // -1
                Console.WriteLine(((int)0b1111_1111_1111_1111_1111_1111_1111_1111).GetType()); // System.Int32
            }

            Console.WriteLine();

            {
                int numerator = 10;
                int denominator = 3;
                int quotient = numerator / denominator;
                Console.WriteLine(quotient); // 3
                int modulus = numerator % denominator;
                Console.WriteLine(modulus); // 1
            }

            Console.WriteLine();

            {
                double numerator = 10;
                double denominator = 3;
                double quotient = numerator / denominator;
                Console.WriteLine(quotient); // 3.3333333333333335
            }

            {
                int numerator = 1;
                int denominator = 0;
                //int quotient = numerator / denominator; // uncomment to see runtime error
                //Console.WriteLine(quotient);
            }

            Console.WriteLine();

            {
                double numerator = 1;
                double denominator = 0;
                double quotient = numerator / denominator;
                Console.WriteLine(quotient); // ∞
            }

            Console.WriteLine();

            {
                double numerator = 0;
                double denominator = 0;
                double quotient = numerator / denominator;
                Console.WriteLine(quotient); // NaN
                Console.ReadKey();
            }
        }
    }
}
