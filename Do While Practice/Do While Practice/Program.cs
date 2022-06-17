using System;

namespace Do_While_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number - ");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 0, sum = 0;
            Console.WriteLine(" ");
            
            while (i < x)
            {
                i++;
                Console.WriteLine("{0}", i);
                sum += i;              
            }
            Console.WriteLine("");
            Console.WriteLine("sum = {0}",sum);


        }
    }
}
