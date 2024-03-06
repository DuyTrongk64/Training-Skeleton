using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date11
    {
        public Date11(string inputDate1, string inputDate2)
        {
            if (DateTime.TryParse(inputDate1, out DateTime date1) && DateTime.TryParse(inputDate2, out DateTime Date2))
            {
                TimeSpan difference = Date2.Subtract(date1);

                Console.WriteLine($"Khoảng cách giữa 2 ngày là {difference.Days} ngày.");
            }
        }
    }
}
