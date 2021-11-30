using System;

class StringReverse
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split('\x020');
        char[] num1 = str[0].ToCharArray();
        Array.Reverse(num1); //거꾸로
        string value = new string(num1);
        int reverseNum1 = int.Parse(value);


        char[] num2 = str[1].ToCharArray();
        Array.Reverse(num2); //거꾸로
        string value2 = new string(num2);
        int reverseNum2 = int.Parse(value2);

        if (reverseNum1 > reverseNum2) Console.WriteLine(reverseNum1);
        else Console.WriteLine(reverseNum2);

    }
}