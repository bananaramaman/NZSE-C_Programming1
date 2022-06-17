using System;

namespace Functions_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
           void findingZero()
            {
                String[] numbers = new string[7];
                Char[] zero;
                int count = 0;
                Char ch = '0';
                String myString="";
                Console.WriteLine("Please input [7] numbers");

                for (int i = 0; i < 7; i++)
                {

                    myString += Console.ReadLine();

                    //   count += zero.//Count(f => (f == ch));
                }

                zero = myString.ToCharArray();
                for (int j = 0; j < zero.Length; j++)
                {
                    if (zero[j] == '0')
                    {
                        count++;
                    }
                }
                
                Console.WriteLine("Occurrences of zero in given numbers is {0}", count);
            }
            findingZero();
        }
    }
}
