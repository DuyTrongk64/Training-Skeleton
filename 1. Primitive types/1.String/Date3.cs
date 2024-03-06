using StringTut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date3
    {
        public Date3(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime nextDay = date.AddDays(1);
                Date2 date2 = new Date2();
                Console.WriteLine($"Hôm sau là {date2.ConvertDayOfWeekToVietnamese(nextDay.DayOfWeek)}, tháng {nextDay.Month}, năm {nextDay.Year}");
            }
        }
    }
}
