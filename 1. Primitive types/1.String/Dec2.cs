using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Dec2
    {
        public Dec2(decimal number)
        {
            string formattedNumber = number.ToString("#,##0.00");

            Console.WriteLine(formattedNumber);
        }
    }
}
