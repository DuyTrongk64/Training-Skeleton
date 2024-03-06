using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int5
    {
        public Int5(string number)
        {
            Int1 int1 = new Int1();
            int num = int.Parse(number);
            if (num <= 0) Console.WriteLine("Số <=0");

            if (num < 2 ) Console.WriteLine("Không phải số nguyên tố");
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
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
