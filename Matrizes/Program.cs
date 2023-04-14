using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double [,] mat = new double[2,3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            int n = int.Parse(Console.ReadLine());

            int[,] mat2 = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat2[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat2[i, i] + " ");
            }

            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat2[i, j] < 0)
                    {
                        count++;
                    }
                }
            }


            //TERNARIOS

            // (condicao) ? valor_se_verdadeiro : valor_se_falso
            double preco = 0;

            double desconto = (preco > 20) ? preco * 0.1 : preco * 0.05;
        }
    }
}
