using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List3
    {
        public List3(List<int> numberList)
        {
            numberList.Reverse();

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
