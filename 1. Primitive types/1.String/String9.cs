using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String9
    {
        public String9(string input) {
            String1 str1 = new String1();
            switch (str1.CheckString(input))
            {
                case 1:
                    Console.WriteLine("Chuoi bị null");
                    break;

                case 2:
                    Console.WriteLine("Chuoi rong");
                    break;

                case 3:
                    Console.WriteLine("Chuoi Space");
                    break;

                case 4:
                    string replacedString = input.Replace("ABC", "DEF", StringComparison.Ordinal);
                    Console.WriteLine(replacedString);
                    break;
            }
            
        }
    }
}
