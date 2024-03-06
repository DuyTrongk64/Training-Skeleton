using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTut
{
    internal class Date2
    {
        public bool checkDate(string inputDate)
        {
            try
            {
                DateTime date = DateTime.ParseExact(inputDate, "dd/MM/yyyy", null);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập ngày theo định dạng dd/mm/yyyy.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ngày không hợp lệ. Hãy nhập ngày trong khoảng thời gian hợp lệ.");
                return false;
            }
        }

        public string ConvertDayOfWeekToVietnamese(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Chủ Nhật";
                case DayOfWeek.Monday:
                    return "Thứ Hai";
                case DayOfWeek.Tuesday:
                    return "Thứ Ba";
                case DayOfWeek.Wednesday:
                    return "Thứ Tư";
                case DayOfWeek.Thursday:
                    return "Thứ Năm";
                case DayOfWeek.Friday:
                    return "Thứ Sáu";
                case DayOfWeek.Saturday:
                    return "Thứ Bảy";
                default:
                    return ""; 
            }
        }
        public Date2() { }
        public Date2(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DateTime nextDay = date.AddDays(1);

                Console.WriteLine($"Hôm nay là {ConvertDayOfWeekToVietnamese(date.DayOfWeek)}, tháng {date.Month}, năm {date.Year}");
            }
        }
    }
}
