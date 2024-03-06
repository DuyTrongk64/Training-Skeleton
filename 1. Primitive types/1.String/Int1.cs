using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int1
    {
        public int checkNumber(string number)
        {
            try
            {
                int num = int.Parse(number);
                if (num < 0) return -1;
                else if (num == 0) return 0;
                else return 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập một số nguyên.");
                return -2;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Số quá lớn hoặc quá nhỏ để được biểu diễn bởi kiểu int.");
                return -2;
            }
        }
        public Int1() { }
        public Int1(string number)
        {
            checkNumber(number);
            if (checkNumber(number) != 1) Console.WriteLine("Số <=0");

            if (int.Parse(number) % 2 == 0) Console.WriteLine("Số chẵn");
            else Console.WriteLine("Số lẻ");
        }

    }
}
