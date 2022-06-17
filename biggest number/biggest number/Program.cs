using System;

namespace biggest_number
{
    class Program
    {

        static void Main(string[] args)
        {
            void biggestnumber()
            {
                Console.WriteLine("Please input [3] numbers");
                var number = (Console.ReadLine().Split(' '));
                double x = double.Parse(number[0]);
                double y = double.Parse(number[1]);
                double z = double.Parse(number[2]);
                double big = 0;

                if (x > y && x > z)
                {
                    big = x;
                }
                if (y > x && y > z)
                {
                    big = y;
                }
                if (z > x && z > y)
                {
                    big = z;
                }
                Console.WriteLine("The biggest number is {0}", big);

                return;
            }
            biggestnumber();
        }


        
        
    }
}
