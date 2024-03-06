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
             
            Console.WriteLine($"Hôm nay là {Tool.ConvertDayOfWeekToVietnamese(today.DayOfWeek)}, tháng {today.Month}, năm {today.Year}");
        }
    }
}
