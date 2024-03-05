using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List8
    {
        public List8(List<int> numberList, int numberX)
        {
            numberList.Reverse();

            numberList.Add(numberX);

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
