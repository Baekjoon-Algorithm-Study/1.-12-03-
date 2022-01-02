using System;
using System.Numerics;

namespace BaekJoon.Baekjoon._2주차_기초_수학1
{
    class _10757
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            
            BigInteger idx1 = BigInteger.Parse(str[0]);
            BigInteger idx2 = BigInteger.Parse(str[1]);
            Console.WriteLine(idx1 + idx2);
        }
    }
}
