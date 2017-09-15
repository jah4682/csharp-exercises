using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> listOfNum = new List<int>();

            //Adding numbers to the list
            listOfNum.Add(1);
            listOfNum.Add(2);
            listOfNum.Add(3);
            listOfNum.Add(4);
            listOfNum.Add(5);
            listOfNum.Add(6);
            listOfNum.Add(7);
            listOfNum.Add(8);
            listOfNum.Add(9);
            listOfNum.Add(10);

            Console.WriteLine(listOfNum);

            //Send list object to sumN function
            int sumeven = SumEven.SumN(listOfNum);

            Console.WriteLine(sumeven);
            Console.ReadLine();
        }
    }
}
