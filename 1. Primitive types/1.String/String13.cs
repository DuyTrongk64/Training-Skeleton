using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String13
    {
        public String13(string input, int number)
        {
            if (input == null)
            {
                Console.WriteLine("Chuoi bị null");
            }
            else if (input == "")
            {
                Console.WriteLine("Chuoi rong");
            }
            else
            {
                int cout = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                    {
                        cout++;
                        continue;
                    }
                }

                if (cout != 0)
                {
                    if (number < 0) Console.WriteLine(" Số nhỏ hơn 0");
                    else
                    {
                        input = input.TrimEnd();
                        for (int i = 0; i < number; i++)
                        {
                            Console.Write(input[i]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Chuoi Space");
                }
            }
        }
    }
}
