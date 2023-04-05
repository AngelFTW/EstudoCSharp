using System;

namespace Moedas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valor = 10.25;
            decimal valor1 = 10.25m;
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));

        }
    }
}
