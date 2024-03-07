using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List7
    {
        public List7()
        {
            List<int> numberList;
            string numberX;
            bool check_num;
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                numberX = Console.ReadLine();
                check_num = Tool.checkNumber(numberX);
                if (check_num && int.Parse(numberX) == 0)
                {
                    Console.WriteLine("Vui lòng nhập số khác 0!");
                }
            } while (!check_num || int.Parse(numberX) == 0);
            Console.Write("\nKết quả: ");
            int number = int.Parse(numberX);
            numberList.Add(number);

            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
