using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int2
    {
        public Int2()
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

            Int1 int1 = new Int1();   
            int num = int.Parse(number);
            Console.WriteLine(Math.Abs(num));
        }
    }
}
