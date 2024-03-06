﻿using StringTut;
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
                Date2 date2 = new Date2();
                Console.WriteLine($"10 ngày trước là {date2.ConvertDayOfWeekToVietnamese(tenDaysAgo.DayOfWeek)}") ;
            }
        }
    }
}
