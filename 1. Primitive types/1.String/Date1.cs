using StringTut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date1
    {
        public Date1()
        {
            DateTime today = DateTime.Today;
            Date2 date2 = new Date2(); 
            Console.WriteLine($"Hôm nay là {date2.ConvertDayOfWeekToVietnamese(today.DayOfWeek)}, tháng {today.Month}, năm {today.Year}");
        }
    }
}
