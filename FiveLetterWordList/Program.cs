using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLetterWordList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new list object and initialize it with words
            List<string> listOfWords = new List<string> { "initialize", "FiveS", "initialize", "Array", "signs" };

            //string message = 
            Console.WriteLine(
                FiveLetters.GetFiveLetters(listOfWords));
            Console.ReadLine();
        }
    }
}

