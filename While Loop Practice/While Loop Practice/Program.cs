using System;

namespace While_Loop_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 1; int sum = 0;
            while (n <= 5)
            {
                sum += n;
                Console.WriteLine("Number {0}",n);
                n++;
            }
            Console.WriteLine("sum = {0}", sum);
        }
    }
}
