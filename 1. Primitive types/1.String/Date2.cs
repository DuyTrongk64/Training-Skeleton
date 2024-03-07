using PrimitiveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTut
{
    internal class Date2
    { 
        public Date2()
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
                DateTime nextDay = date.AddDays(1);

                Console.WriteLine($"Hôm nay là {Tool.ConvertDayOfWeekToVietnamese(date.DayOfWeek)}, tháng {date.Month}, năm {date.Year}");
            }
        }
    }
}
