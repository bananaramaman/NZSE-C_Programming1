using System;

namespace Assignment_1_Task_4
{
    class Program
    {
        //Task 4 - this program calculates expenses as a percentage of monthly net income, & provides guidance depending on the outcome.
        static void Expenses(double salary) //defines function 
        {
            double sum = 0;
            double[] amount = new double[4]; //defines array for user input amount
            string[] feedback = new string[4] { "Too high!", "high", "average", "Good'" }; //defines feedback array 
            string[] areas = new string[4] { "Rent", "Bills", "Groceries", "Misc" }; // defines areas array 
            double percent;
            int x = 0;
            for (int i = 0; i < 4; i++) //defines value for int i, if condition met, i increments.
            {
                Console.Write("{0} = $", areas[i]);
                amount[i] = Convert.ToDouble(Console.ReadLine()); //records user input as value for amount array 
                Console.WriteLine();
                sum += amount[i]; //defines sum as total of amount 
            }
            percent = sum / salary * 100; //defines percent as being the sum percentage of salary
            if (percent >= 100) //check if percent greater or equal to 100
            {
                x = 0;  //if true defines int x as 0
            }
            if (percent >=  80 && percent < 100) //check if percent is greater equal to 80 & less than 100
            {
                x = 1; //if true defines x as 1
            }
            if (percent >= 60 && percent < 80) //check if percent greater than equal to 60 & less than 80
            {
                x = 2;  //if true defines x as 2
            }
            if (percent < 60) //check if percent is less than 60    
            {
                x = 3; //if true defines x as 3
            }
            Console.WriteLine("Your expenses are {0} at {1}% your monthly salary of ${2}", feedback[x], percent, salary); //prints feedback dependent on percentage, + percent + salary 
            switch (x) //switch case
            {
                case 0:
                    Console.WriteLine("Expenses exceed your income, need major adjustments to bills."); //defines switch cases for int x 
                    break;
                case 1:
                    Console.WriteLine("Expenses are high, need minor adjustments to bills.");
                    break;
                case 2:
                    Console.WriteLine("Expenses are average.");
                    break;
                case 3:
                    Console.WriteLine("Expenses are low.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please input your monthly expenses:"); 
            Console.WriteLine();
            Expenses(4000); //defines salary / returns to expenses function
        }
    }
}
