using StringTut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date7
    {
        public Date7()
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
                DateTime tenDaysAgo = date.AddDays(-10);
                
                Console.WriteLine($"10 ngày trước là {Tool.ConvertDayOfWeekToVietnamese(tenDaysAgo.DayOfWeek)}") ;
            }
        }
    }
}
