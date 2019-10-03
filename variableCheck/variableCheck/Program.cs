using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeBasic = -42;
            byte start = 3;
            short negativeTryout = -28;
            long negativeMassive = -1234567890;
            char TheBigOne = 'd';
            sbyte negativeStart = -3;
            ushort Tryout = 28;
            uint Basic = 42;
            ulong Massive = 1234567890;
            float unused = 3.145926f;
            double proper = -3.14592653589;
            decimal accurate = 3.14592653589793238M;
            bool allIs = true;
            string message = "got all of these done I think";
            negativeBasic = -24;
            start = 9;
            negativeTryout = -82;
            negativeMassive = -0987654321;
            TheBigOne = 'D';
            negativeStart = -33;
            Tryout = 82;
            Basic = 27;
            Massive = 0987654321;
            unused = -3.145926f;
            proper = 3.14592653589;
            accurate = -3.14592653589793238M;
            allIs = false;
            message = "Yup Done";
            //Console.WriteLine(negativeBasic);
            //Console.WriteLine(start);
            //Console.WriteLine(negativeTryout);
            //Console.WriteLine(negativeMassive);
            //Console.WriteLine(TheBigOne);
            //Console.WriteLine(negativeStart);
            //Console.WriteLine(Tryout); 
            //Console.WriteLine(Basic); 
            //Console.WriteLine(Massive); 
            //Console.WriteLine(unused); 
            //Console.WriteLine(proper); 
            //Console.WriteLine(accurate); 
            //Console.WriteLine(allIs);
            //Console.WriteLine(message);
            int[] intarray = {negativeBasic, start, negativeTryout,TheBigOne, negativeStart, Tryout};
            Console.WriteLine(intarray);
            Console.ReadKey();
        }
    }
}
