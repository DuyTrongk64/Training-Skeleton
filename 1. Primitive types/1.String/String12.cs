using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String12
    {
        public String12(string input, string number)
        {
            
            switch (String1.CheckString(input))
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
                    Int1 int1 = new Int1();
                    int num = int.Parse(number);
                    if (num < 0)
                    {
                        Console.WriteLine(" Số nhỏ hơn 0");
                    }
                    else
                    {
                        input = input.TrimStart();
                        if(input.Length < num)
                            Console.Write($" Bỏ các ký tự trắng ở đầu chuỗi, lấy {num} ký tự đầu của dãy bạn vừa nhập là: {input}");
                        else
                        Console.Write($" Bỏ các ký tự trắng ở đầu chuỗi, lấy {num} ký tự đầu của dãy bạn vừa nhập là: {input.Substring(0, num)}");
                    }
                    break;
            }
        }
    }
}
