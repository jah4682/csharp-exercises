//Store this sentence in a string, and then prompt the user for a string to search for within this string.
//Print whether or not the search term was found. See if you can make the search case-insensitive, so that searching for "alice" prints true.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            
            //User input
            Console.WriteLine("Type a word or phrase to fine in the first paragraph of Alice in Wonderland.");
            string userInput = Console.ReadLine();

            //Find string
         
            int msg = alice.IndexOf(userInput);

            if (msg == -1)
                Console.WriteLine("Your message was not found");
            else
                Console.WriteLine("Your message was found");



            Console.ReadLine();
        }
    }
}
