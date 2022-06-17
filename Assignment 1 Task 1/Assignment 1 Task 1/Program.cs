using System;

namespace Assignment_1_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1: This program prints the numbers divisible by 5 or 7 from 1 to 100 inclusive

            int sum = 0;
            Console.WriteLine("This Program will print the sum of all numbers ");
            Console.WriteLine("divisible by 5 or 7 from 1 - 100 (both inclusive)");
            Console.WriteLine();
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 5 == 0) //checking if number is divisible by 5
                {
                    Console.Write("{0} ", i); //if true print number
                    sum += i;
                }
                else if (i % 7 == 0) //check id number is divisible by 7
                {
                    Console.Write("{0} ", i); //if true print number
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The sum of all the numbers divisible by 5 or 7");
            Console.WriteLine("between 1 and 100 (inclusive) is: {0}", sum); //prints sum of all numbers that meet the program conditions
        }
    }
}
