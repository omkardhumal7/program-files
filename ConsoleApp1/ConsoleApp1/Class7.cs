using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        static void Main(string[] args)
        {
            Factorial();
        }

        static void Factorial()
        {

            int fact = 1;

            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of number is :" + fact);
            //  Console.WriteLine(fact);
            Console.ReadLine();
        }
    }

}
