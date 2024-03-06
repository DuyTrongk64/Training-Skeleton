using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int1
    {
        public static bool checkNumber(string number)
        {
            try
            {
                int num = int.Parse(number);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập một số nguyên.");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Số quá lớn hoặc quá nhỏ để được biểu diễn bởi kiểu int. Hãy nhập một số nguyên.");
                return false;
            }
        }
        public Int1() { }
        public Int1(string number)
        {
            int num = int.Parse(number);
            if (num <= 0) Console.WriteLine("Số <=0");

            if (num % 2 == 0) Console.WriteLine("Số chẵn");
            else Console.WriteLine("Số lẻ");
        }

    }
}
