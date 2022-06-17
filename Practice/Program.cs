using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User input a number - ");
            int x = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            Console.WriteLine("Even numbers :");

            while (i * 2 <= x)
            {
                Console.WriteLine(i*2 + " ");
                i++;
            }
        }
    }
}
