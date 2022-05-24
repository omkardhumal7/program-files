using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        public static void Main2(string[] args)
        {
            string s;
            string rev = string.Empty;
            Console.WriteLine("Enter String");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if(rev == s)
            {
                Console.WriteLine("String is Pallindrome");
            }
            else
            {
                Console.WriteLine("String is not Pallindrome");
            }
            Console.ReadKey();
        }
    }
}
