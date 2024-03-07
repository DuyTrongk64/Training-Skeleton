using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date6
    {
        public Date6()
        {
            int check = 0;
            bool check_num;
            string inputDate;
            do
            {
                Console.Write("Nhập ngày: ");
                inputDate = Console.ReadLine();

                check_num = Tool.checkDate(inputDate);
            }
            while (!check_num);
            Console.Write("Kết quả: ");
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                string format1 = date.ToString("dd/MM/yyyy");
                Console.WriteLine($"Ngày/tháng/năm: {format1}");

                string format2 = date.ToString("yyyy/MM/dd");
                Console.WriteLine($"Năm/tháng/ngày: {format2}");

                string format3 = date.ToString("MM/yyyy");
                Console.WriteLine($"Tháng/năm: {format3}");

                string format4 = date.ToString("MM-yyyy");
                Console.WriteLine($"Tháng-năm: {format4}");
            }
        }
    }
}
