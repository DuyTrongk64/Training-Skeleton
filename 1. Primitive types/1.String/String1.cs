using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class String1
    {
        public static int CheckString(string input)
        {
            try
            {
                if (input == "")
                {
                    return 2;
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
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public String1() { }
        public String1(string input)
        {
            switch(CheckString(input))
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
                    Console.WriteLine(input);
                    break;
            }
        }
    }
}
