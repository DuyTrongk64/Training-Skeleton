using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List4
    {
        public List4(List<int> numberList, string numberX)
        {
            int number = int.Parse(numberX);

            numberList.RemoveAll(num => num < number);

            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
