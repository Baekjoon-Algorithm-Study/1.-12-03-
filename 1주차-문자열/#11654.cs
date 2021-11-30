using System;
using static System.Console;


namespace 11654
{
    class MainApp
    {
        static void Main(string[] args)
        {
            char a;

            a = Convert.ToChar(Console.ReadLine());

            int b = Convert.ToInt32(a);

            Console.WriteLine($"{b}");
        }
    }

}