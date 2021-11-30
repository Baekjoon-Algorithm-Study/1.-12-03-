using System;
using System.Collections.Generic;
using System.Text;

namespace Solve
{
    class 10809
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 0 + 'a'; i < 26 + 'a'; i++)
            {
                Console.Write(s.IndexOf(Convert.ToChar(i)));
                Console.Write(" ");
            }
        }
    }
}
