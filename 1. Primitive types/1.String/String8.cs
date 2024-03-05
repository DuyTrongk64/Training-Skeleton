using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String8
    {
        public String8(string str1, string str2) {
            int sosanh = String.Compare(str1, str2, true);

            if(sosanh == 0)
            {
                Console.WriteLine($"Chuỗi {str1} giống chuỗi {str1}");
            }
            else Console.WriteLine($"Chuỗi {str1} khác chuỗi {str1}");
        }
    }
}
