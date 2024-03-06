using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimitiveTypes
{
    internal class Int4
    {
        public Int4(string number1, string number2) {
            Int1 int1 = new Int1();
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            Console.WriteLine(num1 % num2);
        }
    }
}
