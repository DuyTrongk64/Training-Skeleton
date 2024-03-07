using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String14
    {
        public String14()
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
            } while (check == 1);

            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);

            } while (!check_num);
            Console.Write("Kết quả: ");
            switch (Tool.CheckString(input))
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
                    
                    int num = int.Parse(number);
                    if (num<0)
                    {
                        Console.WriteLine(" Số nhỏ hơn 0");
                    }
                    else
                    {
                        input = input.Trim();
                        if (input.Length < num)
                            Console.WriteLine($" Bỏ các ký tự trắng ở đầu và cuối chuỗi, lấy {num} ký tự cuối của dãy bạn vừa nhập là: {input}");
                        else
                        Console.WriteLine($" Bỏ các ký tự trắng ở đầu và cuối chuỗi, lấy {num} ký tự cuối của dãy bạn vừa nhập là: {input.Substring(input.Length- num, num)}");
                    }
                    break;
            }
        }
    }
}
