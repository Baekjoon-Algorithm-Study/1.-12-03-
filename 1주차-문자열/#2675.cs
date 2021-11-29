using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solve
{
    class 2675
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine()); //testcase 입력

            string[] arr = new string[testCase]; //testCase만큼 저장할 배열
            string[] str = new string[testCase];
            StringBuilder sb = new StringBuilder(null);

            for (int i = 0; i < testCase; i++)
            {
                arr[i] = Console.ReadLine(); // ex) arr[o] = 3 ABC 입력하는 곳
                str = arr[i].Split(" "); // space로 구분 str = arr[0].Split(" ") 으로 인해 str[0]은 3 str[1]은 ABC

                int num = int.Parse(str[0]); // 3에 해당
                string repeat = str[1]; // 문자열 num에 해당

                for (int q = 0; q < repeat.Length; q++) //ABC길이만큼 반복 즉 3번 반복
                {
                    char a = repeat[q]; //char a 첫번째는 repeat[0]이니깐 즉 A

                    for (int v = 0; v < num; v++) //3만큼 반복
                    {
                        sb.Append(a);
                    }
                }
                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb);
        }
    }
}
