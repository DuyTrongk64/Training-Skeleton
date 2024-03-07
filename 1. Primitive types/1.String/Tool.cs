using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Tool
    {
        public static int CheckString(string input)
        {
            try
            {
                if (input == "")
                {
                    return 2;
                }
                else
                {
                    int cout = 0;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != ' ')
                        {
                            cout++;
                            continue;
                        }
                    }

                    if (cout != 0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public static bool checkNumber(string number)
        {
            try
            {
                int num = int.Parse(number);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập một số nguyên.");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Số quá lớn hoặc quá nhỏ để được biểu diễn bởi kiểu int. Hãy nhập một số nguyên.");
                return false;
            }
        }

        public static bool checkDate(string inputDate)
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

        public static string ConvertDayOfWeekToVietnamese(DayOfWeek dayOfWeek)
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

        public static bool checkDecmial(string input)
        {
            try
            {
                decimal decimalNumber = decimal.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập một số decimal.");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Số quá lớn hoặc quá nhỏ để được biểu diễn bởi kiểu decimal. Hãy nhập một số decimal.");
                return false;
            }
        }
    }
}
