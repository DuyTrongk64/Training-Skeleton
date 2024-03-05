using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Project
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            // Thêm 10 số bất kỳ vào danh sách
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = new Random().Next(1, 100); // Số nguyên ngẫu nhiên từ 1 đến 100
                numberList.Add(randomNumber);
            }

            new List4(numberList, 15);
    
    }
    }
}
