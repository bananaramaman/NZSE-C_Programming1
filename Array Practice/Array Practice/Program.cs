using System;
using System.Linq;
using System.Text;

namespace Array_Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            String[] numbers = new string[7];
            Char[] zero;
            int count = 0;
            Char ch = '0';

            Console.WriteLine("PLease input [7] numbers");

            for (int i = 0; i < 7; i++)
            {
                numbers[i] = Convert.ToString(Console.ReadLine());
                zero = numbers[i].ToCharArray();
                count += zero.Count(f => (f == ch));
            }

            Console.WriteLine("Occurrences of 0 in given array is {0}", count);
        }
    }
}