using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List1
    {
        public List1(List<int> numberList)
        {
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
