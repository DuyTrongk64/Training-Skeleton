using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Dict3
    {
        public Dict3()
        {
            Dictionary<int, string> dictionary = Tool.CreateStudentDictionary();
            bool check;
            string name, number;
            int id;
            do
            {
                Console.Write("\nNhập MSSV: ");
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

            if (dictionary.TryGetValue(id, out string cur_name)) Console.WriteLine($"Đã có SV có mã: {id} trong Dictonary");
            else
            {
                dictionary.Add(id, name);
                Console.WriteLine($"Đã thêm SV có mã {id}, tên {name} vào Dictionary");
            }
        }
    }
}
