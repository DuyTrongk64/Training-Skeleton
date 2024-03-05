using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int6
    {
        public Int6(string input) {
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("Chuoi so");
            }
            else
            {
                Console.WriteLine(" Không phải Chuoi so");
            }
        }
    }
}
