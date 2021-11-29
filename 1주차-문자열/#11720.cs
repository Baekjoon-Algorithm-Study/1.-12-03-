using System;
using System.Collections.Generic;
using System.Text;

namespace 11720
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string sum = Console.ReadLine();

            int add = 0;
            for (int i = 0; i < a; i++)
            {
                add += (int)sum[i] - 48;

            }
            Console.WriteLine($"{add}");
        }
    }
}
