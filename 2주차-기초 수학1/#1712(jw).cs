using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._2주차_기초수학1
{
    class Class1
    {
        static int count=0;
        static void Main()
        {
            string[] order = Console.ReadLine().Split();

            int A = int.Parse(order[0]);
            int B = int.Parse(order[1]);
            int C = int.Parse(order[2]);
           
            if (B >= C) {
                count = -1;
                Console.WriteLine(count);
                return;
            }
            else
            {
                count = A/(C-B)+1;
                Console.Write(count);
            }
        }
    }
}
