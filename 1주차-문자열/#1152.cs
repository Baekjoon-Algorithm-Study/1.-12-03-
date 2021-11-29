using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().Trim();
            string[] arr = str.Split('\x020');
            int count = 0;
         
            for(int i = 0; i < arr.Length; i++)  count++;
            if (str.Length == 0) count = 0;
            Console.WriteLine(count);
        }
    }
}
