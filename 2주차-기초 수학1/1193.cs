using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._2주차_기초_수학1
{
    class _1193
    {
        static int n = 1;
        static int x = 1;
        static void Main()
        {
            

            //1 2 4 7 11
            //x = x+n++;
            //x = 등차수열? 이거 뭐 있었는데 뭐더라;;;
            //계차수열이네
            //아 왜 지그재그야 ㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠ
            // 1+n(n-1)/2
            
            int number = int.Parse(Console.ReadLine());

            int x = 1;
            int n = 1;
            bool isOdd = false;
            //if 9면 n은 5
            while (number-n >= x) // 11-1>=1 , 11-2>=2, 11-3>=4, 11-4>=7, 16-5>=11, 22-6>=16 오 딱맞네
            {
                x = x + n++;
                if (!isOdd) isOdd = true;
                else isOdd = false;
            }

            int order = number - x; // 14-11=3 

            if(isOdd) Console.WriteLine($"{order+1}/{n-order}");
            else Console.WriteLine($"{n-order}/{order+1}");
        }
    }
}
