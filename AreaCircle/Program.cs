// Studio C#: Area of a Circle
//create a console program that calculates the area of a circle based on input from the user.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //area of a circle is A = pi * r * r where pi is 3.14 and r is the radius.
            Console.WriteLine("Enter a radiu for your circle:");
            double radius = double.Parse(Console.ReadLine());
            
            if (radius < 0)
            {
                Console.Write("Error Message. Negative Number");
                Console.ReadLine();
                // Environment.Exit(0); //exits the console
            }

            //Calculation
            double area =  (radius * radius) * 3.14;

            //Write to console window
            Console.WriteLine("The area of a circle with radius " + radius +" is: " + area);
            Console.ReadLine();

        }
    }
}
