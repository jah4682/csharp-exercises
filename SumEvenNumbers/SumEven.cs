using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvenNumbers
{
    class SumEven
    {
        public static int SumN(List<int> numList)
        {

            int box = 0;

            foreach (int index in numList)
            {
                //find even numbers
                if (index % 2 == 0)
                {
                    //add numbers together
                    box = box + index;
                }
            }

            return box;
            

            
        }
    }
}
