using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylinderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a greeting message
            Console.WriteLine("Welcome to Cylinder Calculator!");

            //Read in the cylinder's radius from the user
            Console.WriteLine("Enter the Cylinder's Radius");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            //Read in the cylinder's height
            Console.WriteLine("Enter the Cylinder's Height");
            string HeightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(HeightAsAString);

            double pi = 3.141592654;

            //volume and surface area
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            //result output
            Console.WriteLine("The cylinder's volume: " + volume + " cubic units");
            Console.WriteLine("The cylinder's surface area is: " + surfaceArea + " square units.");

            //user response to close
            Console.ReadKey();
        }
    }
}
