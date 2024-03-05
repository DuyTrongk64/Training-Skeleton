using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date7
    {
        public Date7(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime tenDaysAgo = date.AddDays(-10);

                Console.WriteLine($"10 ngày trước là thứ {tenDaysAgo.DayOfWeek}") ;
            }
        }
    }
}
