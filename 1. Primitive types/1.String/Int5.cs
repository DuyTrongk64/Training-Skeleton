using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int5
    {
        public Int5()
        {
            string number;
            bool check_num;
            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            
            int num = int.Parse(number);
            if (num <= 0)
            {
                Console.WriteLine("Số <=0");
                return;
            }

            if (num < 2 ) Console.WriteLine("Không phải số nguyên tố");
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Không phải số nguyên tố");
                        return;
                    }
                    Console.WriteLine("Số nguyên tố");
                }
            }
        }
    }
}
