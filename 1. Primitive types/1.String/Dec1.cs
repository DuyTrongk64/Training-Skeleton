using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace PrimitiveTypes
{
    internal class Dec1
    {
        public Dec1()
        {
            int check = 0;
            bool check_num;
            string input;
            string number;
            do
            {
                Console.Write("Nhập chuỗi: ");
                input = Console.ReadLine();
                check = Tool.CheckString(input);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);
            Console.Write("Kết quả: ");
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            CultureInfo culture = CultureInfo.InvariantCulture;


            if (decimal.TryParse(input, style, culture, out decimal result))
            {
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi decimal");
            }
        }
    }
}
