using System;

namespace Function_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
             void findEvenOrOdd()
            {
                Console.WriteLine("please input a number ");
                int Number = Convert.ToInt32(Console.ReadLine());

                if (Number % 2 == 0)
                {
                    Console.WriteLine("your number is Even");
                }

                if (Number % 2 != 0)
                {
                    Console.WriteLine("your number is Odd");
                }
                
            }
             findEvenOrOdd();

        }
    }
}
