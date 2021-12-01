using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Baekjoon._1주차_문자열
{
    class Class1
    {
        //delegate int Check_str(string check_str);
        
        static string alpha = "abcdefghijklmnopqrstuvwxyz"; //알파벳 담을 문자열 배열

        static void Main()
        {

            //마지막 문제야 예~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //연속 문자 즉 a가 맨앞에 나왔다고 가정했을 때 aa이렇게는 되는데 aaba 이렇게 끊겼다가 다시 나오면 안된다는 소리지
            //jinwoo 같은 경우는 되고 하나의 연속 문자라고 해줄 수 있지

            //핵심 1) 연속적인지? 2) 같은 문자가 끊겨서 나오는지? 3) 연속적이진 않아도 jinwo(o)처럼 이어지는지?


            int count = 0;

            int roof = int.Parse(Console.ReadLine()); //몇번 루프 돌릴지 첫번째 줄에서 받아
            if (roof > 100) return;
            for (int i = 0; i < roof; i++)
            {
                bool[] ischeck = new bool[26]; //일단 처음엔 전부 false겠지?
                int index = 0; //찾을 인덱스 번호
                
                string str = Console.ReadLine().ToLower(); // 입력값을 받자 연속적이면 count 플러스 1
                if (str.Length > 101) return;
                if (str.Length == 1)
                {
                    count++;
                    continue;
                }
             
                //여기서 확인하자
                for (int p = 1; p < str.Length; p++) //happy => 길이 5 1 2 3 4 aabba 도 길이 5이고 1 2 3 4 
                {
                    if (p == str.Length - 1 && ischeck[alpha.IndexOf(str[p])] == false)
                    {                      
                        count++; //break에서 걸리지 않으면 count추가해줌
                        break;
                    }
                    if (str[p - 1] == str[p])
                    {
                        continue; // aaabbb 일때를 먼저 해보자
                    }
                    else if (str[p - 1] != str[p]) //다를땐 어떡하지 앞에있는애를 false로 만들어서 나중에 또 나오게되면 바로 break로 빠져나가게끔해보자
                    {

                        if (ischeck[alpha.IndexOf(str[p])] == true) break;
                        
                        index = alpha.IndexOf(str[p - 1]); //str[p]의 알파벳 순서를 가져와서 index에 넣어버려 ex) aaabbba일때 p==2일때 여기 부분이 실행 index=str.IndexOf(str[2])이므로 
                                                           //str[2]는 a고 indexOf 할때 0임 즉 index = 0이 들어감 -> ischeck[0] = true가 되고 나중에 true이면 break로 빠져나가버렷
                        ischeck[index] = true; //true이므로 이제 두번다시나오면안됨

                    }

                }
               
            }

            Console.WriteLine($"{count}");  //str을 넣어주고 count의 개수 확인}
        }
    }
}
