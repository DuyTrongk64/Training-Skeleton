using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date11
    {
        public Date11()
        {
            int check = 0;
            bool check_num;
            string inputDate1, inputDate2;
            do
            {
                Console.Write("Nhập ngày: ");
                inputDate1 = Console.ReadLine();

                check_num = Tool.checkDate(inputDate1);
            }
            while (!check_num);

            do
            {
                Console.Write("Nhập ngày: ");
                inputDate2 = Console.ReadLine();

                check_num = Tool.checkDate(inputDate2);
            }
            while (!check_num);
            Console.Write("Kết quả: ");
            if (DateTime.TryParse(inputDate1, out DateTime date1) && DateTime.TryParse(inputDate2, out DateTime Date2))
            {
                TimeSpan difference = Date2.Subtract(date1);

                Console.WriteLine($"Khoảng cách giữa 2 ngày là {difference.Days} ngày.");
            }
        }
    }
}
