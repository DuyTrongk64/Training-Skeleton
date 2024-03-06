using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int1
    {
        public Int1()
        {
            int check = 0;
            bool check_num;
            string input;
            string number;
            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            int num = int.Parse(number);
            if (num <= 0) Console.WriteLine("Số <=0");

            if (num % 2 == 0) Console.WriteLine("Số chẵn");
            else Console.WriteLine("Số lẻ");
        }

    }
}
