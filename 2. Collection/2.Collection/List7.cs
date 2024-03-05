using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List7
    {
        public List7(List<int> numberList, int numberX)
        {
            numberList.Add(numberX);

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
