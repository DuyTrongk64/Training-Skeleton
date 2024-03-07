using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimitiveTypes
{
    internal class Int4
    {
        public Int4() {
            string number1;
            bool check_num;
            do
            {
                Console.Write("Nhập số thứ nhất: ");
                number1 = Console.ReadLine();
                check_num = Tool.checkNumber(number1);
            } while (!check_num);

            string number2;
            do
            {
                Console.Write("Nhập số thứ hai: ");
                number2 = Console.ReadLine();
                check_num = Tool.checkNumber(number2);
                if (check_num && int.Parse(number2) == 0)
                {
                    Console.WriteLine("Vui lòng nhập mẫu số khác không!");
                }
            } while (!check_num || int.Parse(number2) == 0);

            Console.Write("Kết quả: ");

            
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            Console.WriteLine(num1 % num2);
        }
    }
}
