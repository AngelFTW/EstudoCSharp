using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            int m = int.Parse(Console.ReadLine());

            Product[] vect2 = new Product[m];

            for (int i = 0; i < m; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect2[i] = new Product { Name = name, Price = price };
            }

            double sum2 = 0.0;

            for (int i = 0; i < m; i++)
            {
                sum2 += vect2[i].Price;
            }

            double avg2 = sum2 / m;

            Console.WriteLine("AVERAGE PRICE: " + avg2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}