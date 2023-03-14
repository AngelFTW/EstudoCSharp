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







            // split
            string[] vet1 = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);
            double ele = 49;
            double resele;
            resele = Math.Sqrt(ele);
            Console.WriteLine(resele);







            //media idades;
            string nome1, nome2;
            int idade1, idade2;
            string [] vetnome;

            vetnome = Console.ReadLine().Split(' ');
            nome1 = vetnome[0];
            idade1 = int.Parse(vetnome [1]);
            vetnome = Console.ReadLine().Split(' ');
            nome2 = vetnome[0];
            idade2 = int.Parse(vetnome [1]);

            double media;
            media = (double) (idade1 + idade2) / 2.0;
            Console.WriteLine("A media de idade entre " + nome1 + " e " + nome2 + " eh de: " + media + " anos.");







            //conversao hora/minutos/segundos
            int f, horas, resto, minutos, segundos;
            f = int.Parse(Console.ReadLine());

            horas = f / 3600;
            resto = f % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);






            //If & Else
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            soma = nota1 + nota2;

            Console.WriteLine("Nota Final: " + soma);

            if (soma<6.0)
                Console.WriteLine("Reprovado");
            else
                Console.WriteLine("Aprovado");

            




            //Bhaskara
            double a, b, c , delta, r1, r2;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
                Console.WriteLine("Impossivel Calcular");
            else{
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("R1 = " + r1);
                Console.WriteLine("R2 = " + r2);
            }






            //Menor Numero
            int x, y, z;

            string [] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z){
                Console.WriteLine("Menor: " + x);
            }
            else if (y < z){
                Console.WriteLine("Menor: " + y);
            }
            else{
                Console.WriteLine("Menor: " + z);
            }






            //Minutos Excedentes Conta Celular
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutos > 100){
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$" + conta);






            //Switch case dias da semana
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terca";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabado";
                    break;  
                default:
                    dia = "Valor Invalido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + dia);






            //While
            int x, soma;
            soma = 0;
            x = int.Parse(Console.ReadLine());
            while (x != 0){
                soma += x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);





            //While media numeros
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine());

            soma = 0.0;
            cont = 0;
            while (idade >= 0){
                soma += idade;
                cont += 1;
                idade = double.Parse(Console.ReadLine());
            }
            if (cont == 0){
                Console.WriteLine("Impossivel Calcular");
            }
            else{
                media = soma / cont;
                Console.WriteLine(media);
            }





            //For
            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i=0; i<=N; i++){
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);






            //Tabuada for
            int N;
            
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++){
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }






            // Ler 2 valores e mostrar a soma dos numeros impares
            int x, y, min, max, soma;
            
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y){
                min = x;
                max = y;
            }
            else{
                min = y;
                max = x;
            }
            soma = 0;

            for (int i = min+1; i < max; i++){
                if (i % 2 != 0){
                soma += i;
                }
            }
            Console.WriteLine(soma);

            



            //Do While
            double C, F;
            char repet;

            do{
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine());
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: "+ F);
                Console.Write("Deseja repetir (s/n)? ");
                repet = char.Parse(Console.ReadLine());
            }   while (repet == 's');






            //Vetores
            int[] a;
            double[] b;
            string[] c;

            a = new int[10]; // tamanho do array, no caso, 10 casas
            b = new double[5];
            c = new string[8];

            a[3] = 10;

            for (int i = 0; i <5; i++){
                b[i] = i + 10;
            }

            




            //Armazena valores e mostra apenas os negativos
            int n;
            int[] vet;

            n = int.Parse(Console.ReadLine());

            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++){
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < n; i++){
                if (vet[i] < 0){
                    Console.WriteLine(vet[i]);
                }
            }





             //Ler N valores, armazenar e imprimir eles, a soma e a media
            int n;
            double[] a;
            n = int.Parse(Console.ReadLine());

            a = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++){
                a[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < n; i++){
                Console.WriteLine(a[i]);
                }
            
            double soma = 0.0;
            for (int i = 0; i< n; i++){
                soma += a[i];
            }

            double media = soma / n;
            
            Console.WriteLine(soma);
            Console.WriteLine(media);
            





            //Ler N numero de pessoas, depois o nome, idade, altura. Por fim mostrar a altura media e a porcentagem de quem tem menos de 16 anos
            int n;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string [n];
            int[] idades = new int [n];
            double[] alturas = new double [n];

            for (int i = 0; i < n; i++){
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2]);
            }
        }
    }
}