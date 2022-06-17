using System;

namespace power_of_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            void power()
            {
                Console.WriteLine("enter a number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int n = x - 1;
                int sum = x;
                while (n < x && n > 0)
                {
                    sum = sum * x;
                    n--;
                }
                Console.WriteLine("The power of {0} = {1}", x, sum);
                power();
            }
            power();
        }
    }
}
