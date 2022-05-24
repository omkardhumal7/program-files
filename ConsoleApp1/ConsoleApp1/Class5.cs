using System;

namespace Calculater
{
    class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the action you want to perform");
            Console.WriteLine("1 for Addition");
            Console.WriteLine("2 for Subtraction");
            Console.WriteLine("3 for Multiplication");
            Console.WriteLine("4 for Division");
            Console.WriteLine();

            int Choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Addition is = " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Substration is = " + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Multiplication is = " + (a * b));
                    break;

                case 4:
                    Console.WriteLine("Division is = " + (a / b));
                    break;

                default:
                    Console.Write("Please Choose a correct code");
                    break;
            }
        }

    }
}


