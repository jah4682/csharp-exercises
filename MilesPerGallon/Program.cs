//Write a program that asks a user for the number of miles they have driven 
//and the amount of gas they've consumed (in gallons), and print their miles-per-gallon.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            Console.WriteLine("How many miles driven?");
            string mi = Console.ReadLine();
            Console.WriteLine("How much gas consumed?");
            string g = Console.ReadLine();

            int miles = int.Parse(mi);
            int gas = int.Parse(g);

            int MPG = miles / gas;

            Console.WriteLine("Your Miles per gallon is : " + MPG +" mile per gallon");
            Console.ReadLine();
        }
    }
}
