using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        public static void Main3(string[] args)
        {
            int[] myArray = new int[] { 2, 22, 24, 62, 18, 45 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            System.Console.WriteLine(second);
        }
    }
}
