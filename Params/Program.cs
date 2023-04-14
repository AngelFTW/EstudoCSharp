using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);

            Console.WriteLine(s1);

            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s2);

            int s3 = Calculator.Sum(2, 3, 4, 5);

            Console.WriteLine(s3);
        }
    }
}