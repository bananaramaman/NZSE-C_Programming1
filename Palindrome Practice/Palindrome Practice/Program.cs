using System;

namespace Palindrome_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            void palindrome()
            {
                Char[] original;
                Console.WriteLine("This program will determine if your word is a Palindrome");
                Console.Write("Please input your phrase: ");
                string words = Console.ReadLine();
                original = words.ToCharArray();
                int length = original.Length - 1;
                for (int i = 0; i <= length; i++)
                {
                    Console.WriteLine();
                    if (original[i] != original[length])
                        
                        Console.WriteLine("{0} is not a palindrome", words);
                    else
                        Console.WriteLine("{0} is a palindrome", words);

                    return;
                }
            }
            palindrome();
        }       
    }
}
