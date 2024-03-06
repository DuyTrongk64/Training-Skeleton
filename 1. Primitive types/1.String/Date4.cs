using StringTut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date4
    {
        public Date4(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime preDay = date.AddDays(1);
                
                Console.WriteLine($"Hôm trước là {Date2.ConvertDayOfWeekToVietnamese(preDay.DayOfWeek)}, tháng {preDay.Month}, năm {preDay.Year}");
            }
        }
    }
}
