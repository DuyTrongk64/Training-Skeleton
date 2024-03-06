using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Dec2
    {
        public bool checkDecmial(string input)
        {
            try
            {
                decimal decimalNumber = decimal.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập một số decimal.");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Số quá lớn hoặc quá nhỏ để được biểu diễn bởi kiểu decimal. Hãy nhập một số decimal.");
                return false;
            }
        }
        public Dec2() { }
        public Dec2(string input)
        {
            decimal decimalNumber = decimal.Parse(input);

            string formattedNumber = decimalNumber.ToString("#,##0.00");

            Console.WriteLine(formattedNumber);
        }
    }
}
