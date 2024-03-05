using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List4
    {
        public List4(List<int> numberList, int numberX)
        {
           for(int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] < numberX) numberList.RemoveAt(i);
            }

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
