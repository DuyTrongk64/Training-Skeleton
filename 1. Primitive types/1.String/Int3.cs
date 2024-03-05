using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Int3
    {
        public Int3(int number)
        {
            if (number <= 0) Console.WriteLine("Số <=0");
            else
            {
                int result = 1;
                for(int i = 0;i<number; i++)
                {
                    result *= 2;
                }
                Console.WriteLine(result);
            }
        }
    }
}
