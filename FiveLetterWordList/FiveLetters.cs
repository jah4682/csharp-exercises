using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLetterWordList
{
    class FiveLetters
    {
        public static string GetFiveLetters(List<string> Lwords)
        {
            //initate string variable to null
            string msg = "";

            //loop through list
            foreach (string word in Lwords)
            {
                //if item in list is five letters long
                if (word.Length == 5)
                {
                    //append to new string variable
                    
                    msg = msg + word.ToString() + "\n";
                }
            }

            return msg;
        }
    }
}
