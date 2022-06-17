using System;

namespace Assignment_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2: This program collects and stores numbers from the user, then multiplies each by its element value.

            Console.WriteLine("How many numbers would you like to store in the array?");
            int i = Convert.ToInt32(Console.ReadLine()); //stores user input as integer
            Console.WriteLine();
            int[] numbers = new int[i]; //int array length defined as user input int.

            for (int j = 0; j < numbers.Length; j++) //defines active array element, repeats for array length
            {
                Console.Write("Element [{0}] =  ", j);
                numbers[j] = Convert.ToInt32(Console.ReadLine()); //user input stored as array element value
            }
            Console.WriteLine();
            for (int x = 0; x < numbers.Length; x++) //defines array element
            {
                numbers[x] *= x; //takes element values and multiplies by its position in array
                Console.WriteLine("New element value = [{0}]",numbers[x]); // prints new array values
            }

        }
    }
}
