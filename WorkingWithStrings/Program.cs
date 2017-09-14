using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"So-Called\" Life";    Escape character
            //string myString = "What if I need a\nNew Line?";  New Line
            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your c:\ drive";    Escape all special characters inside qoutes.
            //string myString = String.Format("{0} = {1}","First","Second");
            //string myString = String.Format("{0:C}",145.23);      Currency Format
            //string myString = String.Format("{0:N}", 1234567890);  Number format
            //string myString = String.Format("Percentage: {0:P}", .234);   Percentage Format
            //string myString = String.Format("Phone Number: {0:{###) ###-####}",1234567890);  //Custom Format, # symbol to represent each digit to format. Goes from right to left 

            //string myString = " That summer we took threes across the board  ";
            //myString = myString.Substring(6, 14);     Select out substring of characters from sixth position to fourteenth position
            //myString = myString.ToUpper();    Upper Case
            //myString = myString.Replace(" ", "--");     Find space and repalce with double dash
            //myString = myString.Remove(6, 14);    Take out characters from string
            /*myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, 
                myString.Trim().Length);    find the length and trim off blank spaces off the end of string
            */

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //String builder with append method does same thing as for loop but more efficiently.
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }


            Console.WriteLine(myString);
            Console.ReadLine();
            
        }
    }
}
