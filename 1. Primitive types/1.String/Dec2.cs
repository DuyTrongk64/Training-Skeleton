using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Dec2
    {
        public Dec2()
        {
            int check = 0;
            bool check_num;
            string input;
            string number;
            do
            {
                Console.Write("Nhập chuỗi: ");
                input = Console.ReadLine();
                check_num = Tool.checkDecmial(input);
            }
            while (!check_num);
            Console.Write("Kết quả: ");
            decimal decimalNumber = decimal.Parse(input);

            string formattedNumber = decimalNumber.ToString("#,##0.00");

            Console.WriteLine(formattedNumber);
        }
    }
}
