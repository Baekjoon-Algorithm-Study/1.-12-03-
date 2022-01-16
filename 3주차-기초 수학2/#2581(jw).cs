using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _1978
    {
        static void Main(string[] args) {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int count = 0;
            int minValue =10000;

        
        for (int i = M; i<=N; i++)
            {
                int A = i;
                bool B = true;
                if (A == 1) continue;
                if (A==2 || A==3)
                {
                    count += A;
                    if (minValue > A) minValue = A;
                    continue;
                }
                    int two = 2;
                while (two != A-1)
                {
                    B = A % two++ == 0 ? false : true;

                    if (!B) break;
                }
                if (B)
                {
                    if (minValue > A) minValue = A;
                    count += A;

                }
            }
            if (count == 0)
            {
                Console.WriteLine(-1);
                return;
            }
            Console.WriteLine(count);
            Console.WriteLine(minValue);
        }
    }
}
