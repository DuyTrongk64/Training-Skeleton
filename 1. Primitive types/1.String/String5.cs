﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String5
    {
        public String5(string input)
        {
            
            switch (String1.CheckString(input))
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
                    int coutSpace = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ' ') coutSpace++;
                    }

                    Console.WriteLine($"Có {coutSpace} ký tự space");
                    break;
            }
        }
    }
}
