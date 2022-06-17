using System;

namespace Calculate
{
    class Program
    {
        static void Calculate(int[] numbers)
        {
            int[] CalculateMultiTable = new int[10] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            Calculate(CalculateMultiTable);
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine((i * j).ToString() + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}
