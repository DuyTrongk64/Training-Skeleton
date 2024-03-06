using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String4
    {
        public String4(string input)
        {
            String1 str1 = new String1();
            switch (str1.CheckString(input))
            {
                case 1:
                    Console.WriteLine("Chuoi bị null");
                    break;

                case 2:
                    Console.WriteLine("Chuoi rong");
                    break;

                case 3:
                    Console.WriteLine("Chuoi Space");
                    break;

                case 4:
                    for (int i = 1; i < input.Length; i++)
                    {
                        if (input[i] != ' ' && input[i - 1] == ' ')
                        {
                            Console.Write(char.ToUpper(input[i]));
                            continue;
                        }
                        Console.Write(input[i]);
                    }
                    break;
            }
        }
    }
}
