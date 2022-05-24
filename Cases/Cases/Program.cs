using System;

namespace Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            //int numb = 5;
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;
            }
        }
    }
}
