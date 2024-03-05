using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int1
    {
        public Int1(int number) {
            if (number <= 0) Console.WriteLine("Số <=0");

            if (number %2 ==0) Console.WriteLine("Số chẵn");
            else Console.WriteLine("Số lẻ");
        }

    }
}
