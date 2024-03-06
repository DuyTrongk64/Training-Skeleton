using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Dict2
    {
        public Dict2()
        {
            Dictionary<int, string> dictionary = Tool.CreateStudentDictionary();
            bool check;
            string number;
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

            if (dictionary.TryGetValue(id, out string name)) Console.WriteLine($"Tên sinh viên với MSSV: {id} là {name}");
            else Console.WriteLine($"Không có SV có mã {id}");

        }
    }
}
