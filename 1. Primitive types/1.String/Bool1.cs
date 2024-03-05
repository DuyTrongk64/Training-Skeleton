using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Bool1
    {
        public Bool1(string input)
        {
            if (bool.TryParse(input, out bool result))
            {
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi bool");
            }
        }
    }
}
