using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Collection
{
    internal class Dict1
    {
        public Dict1()
        {
            Dictionary<int,string> dictionary = Tool.CreateStudentDictionary();
            Console.WriteLine("\nKết quả: ");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"MSSV: {kvp.Key}, Tên sinh viên: {kvp.Value}");
            }
        }

    }
}
