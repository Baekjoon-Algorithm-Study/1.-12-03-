using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._2주차_기초_수학1
{
    class _2775
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[,] peopleNum = new int[15,15]; //1<=k,n<=14
            //1층과 각 층의 1호를 제외하고는 i번째 호의 사는사람들의 수는 i-1번째 호 사람 수 더하기 바로 아래층 사람

            for (int i = 0; i < 15; i++) peopleNum[0 , i] = i; //1층엔 1씩증가
            for(int i = 1; i < 15; i++) //1층부터 시작
            {
                //i는 층 k는 호
                for(int k = 1; k < 15; k++)
                {
                    if (k == 1) peopleNum[i, k] = 1;
                    else
                    {
                        peopleNum[i, k] = peopleNum[i - 1, k] + peopleNum[i, k - 1];
                        //바로아래층 + 왼쪽호수
                    }
                }
            }

            for(int i = 0; i < number; i++)
            {
                int k = int.Parse(Console.ReadLine()); //k층
                int n = int.Parse(Console.ReadLine()); //n호
                Console.WriteLine(peopleNum[k,n]);
            }
        }
    }
}
