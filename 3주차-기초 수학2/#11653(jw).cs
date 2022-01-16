using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _1978
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());

            for (int i = 2; i <= M; i++)
            {
                if (M % i == 0)
                {
                    Console.WriteLine(i);
                    M /= i;
                    i--;
                }
            }
            if (M > 1) Console.WriteLine(M);

        }
    }
}
