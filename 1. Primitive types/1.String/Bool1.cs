using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Bool1
    {
        public Bool1()
        {
            int check = 0;
            bool check_num;
            string input;
            string number;
            Console.Write("Nhập chuỗi số: ");
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
