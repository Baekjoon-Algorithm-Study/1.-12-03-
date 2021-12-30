using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._2주차_기초_수학1
{
    class _10250
    {
        static void Main()
        {
            // T만큼 입력 H층수 W너비 N 몇번째 손님 1<=H, W<=99 

            int num = int.Parse(Console.ReadLine());


            for(int i = 0; i < num; i++)
            {
                string[] order = Console.ReadLine().Split();

                int H = int.Parse(order[0]);
                int W = int.Parse(order[1]);
                int N = int.Parse(order[2]);

                int row = N > H ? N%H !=0 ? N / H + 1 : N/H : 1;
                int col = N % H ==0? H : N%H;

                Console.WriteLine("{0}{1:00}", col , row);
            }
        }
    }
}
