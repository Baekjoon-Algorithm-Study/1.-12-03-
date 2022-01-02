using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._2주차_기초_수학1
{
    class _2292
    {
        static void Main()
        {
            // 7보다 작으면 1칸 19보다 작으면 2칸 37보다 작으면 3칸 61.......
            // x = x + 6n => x+=6n;
            // 1 7 19 37
            // ex 35가 걸렷으면 35<37인데 즉 3칸인데
            int number;
            int n=1;
            number = int.Parse(Console.ReadLine());

            int x = 1;

            while (number > x)
            {
                x += 6*n++; // (2)1+6 = 7, (3)7+12 = 19,(4) 19+18 =37, (5)37+24 = 61
            }

            Console.WriteLine(n);
        }
    }
}
