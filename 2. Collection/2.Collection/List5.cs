using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List5
    {
        public List5(List<int> numberList, int numberX)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i]%numberX==0) numberList.RemoveAt(i);
            }

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
