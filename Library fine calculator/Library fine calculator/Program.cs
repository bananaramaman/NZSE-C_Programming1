using System;

namespace Library_fine_calculator
{
    class Program
    {
        static void libraryfine(int number)
        {
            Boolean membership = true;
            double fine = 0.0;
            if (number <= 0)
            {
                Console.WriteLine("Check date, and re-enter...");
                return;
            }
            else if (number >= 0 && number <= 5)
            {
                fine = 0.0;
            }
            else if (number > 5 && number <= 10)
            {
                fine = 0.5 * (number - 5);
            }
            else if (number > 10 && number <= 30)
            {
                fine = 1.0 * (number - 5);
            }
            else if (number > 30)
            {
                membership = false;
                fine = 1.5 * (number - 5);
            }
            if (!membership)
            {
                Console.WriteLine();
                Console.WriteLine("YOUR MEMBERSHIP HAS BEEN CANCELED");
            }
            if (fine > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Your book is {0} day(s) overdue", number - 5);
                Console.WriteLine("Total overdue charge = ${0}", fine);
            }
            else
                Console.WriteLine();
                Console.WriteLine("Thank you for returning your book(s) on time");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the date of issue: DD/MM/YYYY");
            DateTime doi = Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan sum;
            sum = now.Subtract(doi);
            libraryfine(Convert.ToInt32(sum.TotalDays));
        }
    
    }
}
