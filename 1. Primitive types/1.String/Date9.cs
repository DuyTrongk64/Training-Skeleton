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
        public Date9(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime lastDayOfYear = new DateTime(date.Year, 12, DateTime.DaysInMonth(date.Year, 12));
                
                Console.WriteLine($"Ngày cuối năm là {Date2.ConvertDayOfWeekToVietnamese(lastDayOfYear.DayOfWeek)}");
            }
        }
    }
}
