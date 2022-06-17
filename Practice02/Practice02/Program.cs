using System;

namespace Practice02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your total combined grades - ");

            int number = Convert.ToInt32(Console.ReadLine());


            if (number < 60)
            {
                Console.WriteLine("With a score of {0} points, your final grade is F.", number);
                Console.WriteLine("See you in the coal mines, Comrade...");
            }

            else

            if (number >= 60 && number <= 70)
            {
                Console.WriteLine("With a score of {0} points, your final grade is C.", number);
            }

            else

            if (number >70 && number <=80)
            {
                Console.WriteLine("With a score of {0} points, your final grade is B", number);
            }

            else

            if (number > 80 && number <= 90)
            {
                Console.WriteLine("With a score of {0} points, your final grade is A", number);
            }

            else

            if (number > 90 && number <=100)
            {
                Console.WriteLine("With a score of {0} points, your final grade is A+.", number);
            }

        }
    }
}
