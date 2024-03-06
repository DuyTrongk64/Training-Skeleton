using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List6
    {
        public List6(List<int> numberList, string numberX)
        {
            int number = int.Parse(numberX);
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] < number) numberList[i]+= number;
            }

            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
