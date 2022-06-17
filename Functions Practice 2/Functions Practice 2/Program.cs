using System;


namespace palindrome
{
    class Program
    {
        /// <summary>
        /// Determines whether the string is a palindrome
        /// </summary>
        static bool palindrome(string words)
        {
            int i = 0;
            int j = words.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = words[i];
                char b = words[j];

                //Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    i++;
                    if (i > j)
                    {
                        return true;
                    }
                    a = words[i];
                }
                //Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    j--;
                    if (i > j)
                    {
                        return true;
                    }
                    b = words[j];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
        static void Main()
        {
            Console.WriteLine("This program checks if your word/phrase is a Palindrome");
            Console.WriteLine("Please input a word or phrase: ");
            string[] input = { Console.ReadLine() };

            foreach (string words in input)
            {
                Console.WriteLine("{0} = {1}", words, palindrome(words));
            }
        }
    }
}
