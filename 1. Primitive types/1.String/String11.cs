using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class String11
    {
        public String11(string input) {

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
                    char[] charArray = input.ToCharArray();
                    int length = input.Length;

                    for (int i = 0; i < length / 2; i++)
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[length - i - 1];
                        charArray[length - i - 1] = temp;
                    }
                    Console.WriteLine(charArray);
                    break;
            }

        }   
    }
}
