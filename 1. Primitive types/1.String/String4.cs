﻿using System;
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
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != ' ' && input[i - 1] == ' ')
                        {
                            Console.Write(char.ToUpper(input[i]));
                            continue;
                        }
                        Console.Write(input[i]);
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