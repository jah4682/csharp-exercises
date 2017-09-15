using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create array and initialize it with numbers
            int[] nums = {1, 1, 2, 3, 5, 8};

            // call method and print  
            Console.WriteLine(
                PrintArray.GetArray(nums));
            Console.ReadLine();
        }
    }
}
