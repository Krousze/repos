using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 10 whole numbers");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int x;
                int.TryParse(Console.ReadLine(),out x);
                sum += x;
            }
            Console.WriteLine("sum = " + sum + "!");
            Console.ReadKey();
        }
    }
}
