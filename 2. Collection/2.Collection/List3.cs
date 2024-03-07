using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class List3
    {
        public List3()
        {
            List<int> numberList;
            string number;
            bool check_num;
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nKết quả: ");

            numberList.Reverse();

            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
