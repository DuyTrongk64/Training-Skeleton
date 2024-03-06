using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class String1
    {
        public String1()
        {
            string input;
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
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
                    Console.WriteLine(input);
                    break;
            }
            Console.WriteLine("");
        }
    }
}
