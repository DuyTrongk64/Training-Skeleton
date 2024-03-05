using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String7
    {
        public String7(string str1, string str2)
        {
            if(str1 == str2)
            {
                Console.WriteLine($"Chuỗi {str1} giống chuỗi {str1}");
            }
            else Console.WriteLine($"Chuỗi {str1} khác chuỗi {str1}");
        }
    }
}
