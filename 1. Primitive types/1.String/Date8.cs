using StringTut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date8
    {
        public Date8(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime lastDayOfMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                
                Console.WriteLine($"Ngày cuối tháng là {Tool.ConvertDayOfWeekToVietnamese(lastDayOfMonth.DayOfWeek)}");
            }
        }
    }
}
