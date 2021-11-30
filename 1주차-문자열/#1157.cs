using System;
using System.Collections.Generic;
using System.Text;

namespace Solve
{
    class Program
    {
       static int[] count = new int[26];
       static char[] charValue = new char[26];
            
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower(); //첫째줄에 100만개 까지 문자가 들어올 수 있음
            int strLength = str.Length;
            if (strLength == 1)
            {
                Console.WriteLine(str.ToUpper());
                return;
            }
 
            _init(str, strLength);
             finally_jop(str, strLength);
        }

        static void finally_jop(string str, int strLength)
        {
            int max = 0;
            int index = 0; //index 0으로 초기화
            char last = '0'; //그냥 초기화
            bool isokay = false;

            for (int i = 0; i < 26; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    index = i;
                    last = charValue[i];
                    isokay = false;
                }
                else if (count[i] == max && last != charValue[i])// abbb 1 3 0000
                {
                    last = '?';
                    isokay = true;
                }
                if (!isokay) last = charValue[index];
            }
            Console.WriteLine(last.ToString().ToUpper());
        }

        static void _init(string str, int strLength)
        {
            for(int i = 0; i < 26; i++)
            {
                charValue[i] = (char)(i+(int)'a');
            }
            for (int i = 0; i < strLength; i++) 
            {
                char what = str[i]; //what에는 입력받은 str의 0부터 인덱스를 받아옴
                for (int p = 0; p <26; p++) //알페뱃 개수만큼 돌려
                {
                    if (what == charValue[p]) count[p]++; //what이 charValue 랑 같으면 그 인덱스 번호에 해당하는 count 증가
                    //ex) ABC Bart이면 str[0]일때 A이고 what은 A인데 A==charValue[p]이려면 p는 0이고 그러면 count[0]에 1증가임
                    //count는 {2,2,1,....}이 되겠지
                }
            }
        }
    }
}

