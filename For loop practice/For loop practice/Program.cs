using System;

namespace For_loop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number - ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum =+ i * number;
                Console.WriteLine("{0} x {1} = {2}", number, i, sum);
            }

            
            

         
            
                
            
        }
    }
}
