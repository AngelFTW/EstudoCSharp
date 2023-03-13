using System;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aoba!");
            double x = 10.35684;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); // 2 casas decimais  

            int z;
            double y;
            y = 5.0;
            z = (int)y; // casting

            Console.WriteLine("\b");
            Console.WriteLine(z);
            Console.WriteLine(y);


            double b,B,h,area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (B+b) / 2.0 * h;
            Console.WriteLine("\b");
            Console.WriteLine(area);


            string frase = Console.ReadLine();
            Console.WriteLine(frase);
            string j = Console.ReadLine();
            string k = Console.ReadLine();
            string l = Console.ReadLine();

            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);

            string s = Console.ReadLine();
            string [] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            int n1 = int.Parse(Console.ReadLine()); // poder ler em int
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            string[] vet1 = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);
            double ele = 49;
            double resele;
            resele = Math.Sqrt(ele);
            Console.WriteLine(resele);
        }
    }
}