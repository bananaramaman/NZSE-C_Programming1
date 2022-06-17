using System;

namespace Assignment_1_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3 - This program provides Multiples and Factors of a number input by the user. 

            Console.WriteLine("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine()); //saves user input as int number
            int sum;
            Console.WriteLine();

            if (number % 2 == 0) //checks if int number is divisible by 2
            {
                Console.WriteLine("Your number is even"); //if true prints message
            }
            for (int i = 1; i <= 5; i++) //defines the value for int i, if condition met, i is incremented
            {
                if (number % 2 == 0) //checks if number divisible by 2
                {
                    sum = number * i; //defines sum as user input multiplied by i
                    Console.WriteLine("{0} * {1} = {2}", number, i, sum); //print user input * i = sum 
                }
            }
            if (number % 2 != 0) //check if number is NOT divisible by 2
            {
                Console.WriteLine("Your number is odd");  //if true prints message
                if (number % 5 == 0) //checks if number is divisible by 5
                {
                    Console.WriteLine("And is a multiple of 5"); //if true prints message
                }
            }
        }
    }
}
