using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    
    internal class List9
    {
        static List<int> GenerateFibonacciList()
        {
            List<int> fibonacciList = new List<int>();
            int first = 0, second = 1;

            for (int i = 0; i < 15; i++)
            {
                fibonacciList.Add(first);

                int temp = first;
                first = second;
                second = temp + second;
            }

            return fibonacciList;
        }

        public List9(string numberX)
        {
            List<int> fibonacciList = GenerateFibonacciList();

            int number = int.Parse(numberX);
            for(int i = 0;i < fibonacciList.Count; i++)
            {
                if(i<10)
                {
                    if (fibonacciList[i] < number)
                    {
                        Console.Write(fibonacciList[i]+" ");
                    }
                }
                else break;
            }
        }
    }
}
