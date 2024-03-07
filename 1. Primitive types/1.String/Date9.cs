using StringTut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date9
    {
        public Date9()
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
                DateTime lastDayOfYear = new DateTime(date.Year, 12, DateTime.DaysInMonth(date.Year, 12));
                
                Console.WriteLine($"Ngày cuối năm là {Tool.ConvertDayOfWeekToVietnamese(lastDayOfYear.DayOfWeek)}");
            }
        }
    }
}
