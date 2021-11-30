using System;
using System.Collections.Generic;
using System.Linq;

class StringReverse
{
    static void Main()
    {
        string[] croatia = new string[8] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        string str = Console.ReadLine();
        
        for (int i = 0; i < croatia.Length; i++)
        {
            if (str.Contains(croatia[i])) str = str.Replace(croatia[i], "#");
        }

        int count = str.Length;
        Console.WriteLine(count);
    }
}