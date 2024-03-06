using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int2
    {
        public Int2(string number)
        {
            Int1 int1 = new Int1();   
            int num = int.Parse(number);
            Console.WriteLine(Math.Abs(num));
        }
    }
}
