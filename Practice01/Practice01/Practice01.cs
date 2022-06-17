using System;

namespace Practice01
{
    public class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            int number;

            Console.Write("Enter Total Parking Time (in hrs) - ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            number = Convert.ToInt32(userInput);
            int x = 6;
                    
            {
                if (number < 2)
                    x = 6;

                else

               if (number >= 2 && number <= 4)
                    x = number * 3 + 3;

                if (number >= 5)
                    x = number * 4 - 1;
            }
            Console.WriteLine(".");
            Console.WriteLine("...Calculating...");
            Console.WriteLine(".");
            Console.WriteLine("Your total cost is ${0}", x); 
            Console.WriteLine();
            Console.WriteLine("####!!!!CARD DECLINED!!!!####");
            Console.WriteLine();
            Console.WriteLine("Have a great day & please drive safely") ;






        }



    }

}

