using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String9
    {
        public String9(string str) {
            string replacedString = str.Replace("ABC", "DEF", StringComparison.Ordinal);

            Console.WriteLine(replacedString);
        }
    }
}
