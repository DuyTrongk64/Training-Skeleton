﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String6
    {
        public String6(string input)
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
                    int coutNotSpace = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != ' ') coutNotSpace++;
                    }

                    Console.WriteLine($"Có {cout} ký tự không phải space");
                }
                else
                {
                    Console.WriteLine("Chuoi Space");
                }
            }
        }
    }
}