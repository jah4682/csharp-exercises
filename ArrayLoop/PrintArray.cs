using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoop
{
    class PrintArray
    {
        public static string GetArray(int[] n)
        {
            string x = "done";

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]/*+"\n"*/);
            }

            return x;
        }
    }
}
