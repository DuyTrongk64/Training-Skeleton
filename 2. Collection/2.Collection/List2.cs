using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List2
    {
        public List2(List<int> numberList)
        {
            numberList.Sort();

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
