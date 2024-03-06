using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List7
    {
        public List7(List<int> numberList, string numberX)
        {
            int number = int.Parse(numberX);
            numberList.Add(number);

            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
