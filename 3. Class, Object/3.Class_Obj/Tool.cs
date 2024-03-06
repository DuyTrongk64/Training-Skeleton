using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj
{
    internal class Tool
    {
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

        public static bool CheckString(string input)
        {
            try
            {
                if (input == "")
                {
                    Console.WriteLine("Không được để trống. Xin vui lòng nhập lại");
                    return false;
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
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Toàn space. Xin vui lòng nhập lại");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tên không hợp lệ. Xin vui lòng nhập lại");
                return false;
            }
        }
    }
}
