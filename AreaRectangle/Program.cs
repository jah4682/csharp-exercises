//Write a program to calculate the area of a rectangle and print the answer to the console. 
//You should prompt the user for the dimensions.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int height;
            int width;
            //input from user
            Console.WriteLine("input the height of rectangle");
            string ht = Console.ReadLine();
            Console.WriteLine("input the width of rectangle");
            string wd = Console.ReadLine();

            //Convert
            height = int.Parse(ht);
            width = int.Parse(wd);
            //Calculation
            int area = height * width;

            //Output
            Console.WriteLine("The area of a rectangle is: " + area);
            Console.ReadLine();


        }
    }
}
