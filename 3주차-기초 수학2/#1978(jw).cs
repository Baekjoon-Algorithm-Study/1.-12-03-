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
            int counting = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split();
            
            int decimalCount=0;

            for (int i = 0; i < counting; i++)
            {
                int A = int.Parse(numbers[i]);
                bool B = true;
                if (A == 1) continue;
                if (A==2 || A==3)
                {
                    decimalCount++;
                    continue;
                }
                int two = 2;
                while (two != A-1)
                {
                    B = A % two++ == 0 ? false : true;
                    if (!B) break;
                }
                if (B) decimalCount++;
            }
            Console.WriteLine(decimalCount);
        }

    }
}
