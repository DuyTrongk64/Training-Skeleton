using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String8
    {
        public String8() {
            int check = 0;
            string input1;
            do
            {
                Console.Write("Nhập chuỗi 1: ");
                input1 = Console.ReadLine();
                check = Tool.CheckString(input1);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);
            string input2;
            do
            {
                Console.Write("Nhập chuỗi 2: ");
                input2 = Console.ReadLine();
                check = Tool.CheckString(input2);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);

            Console.Write("Kết quả: ");
            int sosanh = String.Compare(input1, input2, true);

            if(sosanh == 0)
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
        }
    }
}
