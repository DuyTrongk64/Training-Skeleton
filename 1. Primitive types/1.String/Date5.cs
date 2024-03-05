using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Date5
    {
        public Date5(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime today = DateTime.Today;

                int compareResult = DateTime.Compare(date, today);

                if (compareResult == 0)
                {
                    Console.WriteLine("Ngày hôm nay.");
                }
                else if (compareResult > 0)
                {
                    Console.WriteLine("Ngày tương lai.");
                }
                else
                {
                    Console.WriteLine("Ngày quá khứ.");
                }
            }
        }
    }
}
