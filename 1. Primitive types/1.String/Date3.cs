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

                Console.WriteLine($"Hôm sau là thứ {nextDay.DayOfWeek}, tháng {nextDay.Month}, năm {nextDay.Year}");
            }
        }
    }
}
