using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int5
    {
        public Int5(int number)
        {
            if (number <= 0) Console.WriteLine("Số <=0");

            if (number <2 ) Console.WriteLine("Không phải số nguyên tố");
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Không phải số nguyên tố");
                        return;
                    }
                    Console.WriteLine("Số nguyên tố");
                }
            }
        }
    }
}
