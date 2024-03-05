using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class String1
    {
        public String1(string input) {
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
                    Console.WriteLine(input);
                }
                else
                {
                    Console.WriteLine("Chuoi Space");
                }
            }
        }
        
    }
}
