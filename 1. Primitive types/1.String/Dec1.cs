using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace PrimitiveTypes
{
    internal class Dec1
    {
        public Dec1(string input)
        {

            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            CultureInfo culture = CultureInfo.InvariantCulture;


            if (decimal.TryParse(input, style, culture, out decimal result))
            {
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi decimal");
            }
        }
    }
}
