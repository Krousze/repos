using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassProblem
{
    class Program
    {
        static void Main()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            int sum = ArraySum.simpleArraySum(myArray);
            Console.WriteLine(sum);
        }
    }
        
    class ArraySum 
    { 
            public static int simpleArraySum(int[] theArray)
        {
            int sum = 0;
            foreach (int element in theArray)
            {
                sum += element;
            }
            return sum;
        }
    }
}
