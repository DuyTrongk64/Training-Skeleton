using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Collection
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
                    Console.WriteLine("Không được để tên trống. Xin vui lòng nhập lại");
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
                        Console.WriteLine("Tên toàn space. Xin vui lòng nhập lại");
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

        public static List<int> crateList()
        {
            List<int> numberList = new List<int>();

            // Thêm 10 số bất kỳ vào danh sách
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = new Random().Next(1, 100); // Số nguyên ngẫu nhiên từ 1 đến 100
                numberList.Add(randomNumber);
            }

            return numberList;
        }

        public static Dictionary<int, string> CreateStudentDictionary()
        {
            Dictionary<int, string> studentDictionary = new Dictionary<int, string>();

            // Thêm vào Dictionary 5 giá trị
            //studentDictionary.Add(1001, "Nguyen Van A");
            //studentDictionary.Add(1002, "Tran Thi B");
            //studentDictionary.Add(1003, "Hoang Van C");
            //studentDictionary.Add(1004, "Le Thi D");
            //studentDictionary.Add(1005, "Pham Van E");

            string number;
            string name;
            int id;
            bool check;
            Console.WriteLine("Nhập Dictionary: \n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nhập sinh viên thứ {i + 1}: ");
                do
                {
                    Console.Write("Nhập MSSV: ");
                    number = Console.ReadLine();
                    check = Tool.checkNumber(number);
                    if (check && int.Parse(number) <= 0)
                    {
                        Console.WriteLine("Vui lòng nhập số lớn hơn 0!");
                    }
                } while (!check || int.Parse(number) <= 0);

                id = int.Parse(number);

                do
                {
                    Console.Write("Nhập tên sinh viên: ");
                    name = Console.ReadLine();
                    check = Tool.CheckString(name);
                } while (!check);

                studentDictionary.Add(id, name);
            }



            return studentDictionary;
        }
    }
}
