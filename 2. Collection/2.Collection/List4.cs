using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List4
    {
        public List4()
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
            } while (!check_num);
            Console.Write("\nKết quả: ");
            int number = int.Parse(numberX);

            numberList.RemoveAll(num => num < number);

            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
