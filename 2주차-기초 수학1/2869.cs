using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._2주차_기초_수학1
{
    class _2869
    {
        static void Main()
        {
            string[] order = Console.ReadLine().Split();

            int A = int.Parse(order[0]);
            int B = int.Parse(order[1]);
            int V = int.Parse(order[2]);
            int count;

            //하루에 A미터 올라가고 밤에B미터 내려감, V미터 나무를 올라가야함
            count = (V - A) % (A - B) == 0 ? (V-A)/(A-B) + 1 : (V - A) / (A - B) + 2;

            Console.WriteLine(count);
        }
    }
}
