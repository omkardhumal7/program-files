using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            int personAge = 17;

            if (personAge < 18)
            {
                Console.WriteLine("Person is not able to vote");

            }
            else if (personAge > 18 && personAge <= 60)
            {
                Console.WriteLine("Person is able to vote");
            }

            else

                Console.WriteLine("Person is a senior citizen");
        }
    }
}
