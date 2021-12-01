using System;

class StringReverse
{
    static char[] arr = new char[26]; //알파벳 a부터 z까지 미리 정의하자
    static int[] count = new int[26]; //인덱스 0부터 25까지 미리 카운팅을 해놓자
    static void Main()//     y z 
    {
        string str = Console.ReadLine(); //다이얼 알파벳 가져오기 A~C 2초 그다음부턴 1초씩늘어나서 Z까지 10초 걸림
        int max = 0;
        int value = 3;
        for (int i = 0; i < 26; i++) arr[i] = (char)(i + (int)'A'); //arr에는 A~Z가 들어가 있음
        for (int i = 0; i < 26; i = i + 3)
        {
            if (i == 15)
            {
                count[i] = value;
                count[i + 1] = value;
                count[i + 2] = value;
                count[i + 3] = value++;
                ++i;
                continue;
            }
            count[i] = value;
            count[i + 1] = value;
            count[i + 2] = value++; //이렇게 해놓으면 count 에는 { 2,2,2,3,3,3,4,4,4....} 저장되어있겠지
            if (i == 22)
            {
                count[i + 3] = --value;
                break;
            }
        }
        for (int i = 0; i < str.Length; i++) //입력받은 길이만큼 반복하고 더해주자
        {
            char what = str[i];
            for (int k = 0; k < 26; k++)
            {
                if (what == arr[k]) max += count[k];
            }
        }
        Console.WriteLine(max);
    }
}