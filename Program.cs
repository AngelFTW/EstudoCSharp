using System;

namespace Balta// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const int idadeMinima = 18;
            
            bool aopa = false;

            object quantidade;

            int? idade = null;

            int x = -20;
            uint y = (uint) x;

            Console.WriteLine(y + " " + y.GetType());
            
            var valor = 0;

            do{
                Console.WriteLine("Opa");
                valor++;
            } while(valor < 5);

            aoba("oi meu chapa");

            var nomesob = nome("Gab", "Gouveia");
            

            var arr = new string[2];
            arr[0] = "item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "item 2";

            
            Console.WriteLine(arr[0]);            
            Console.WriteLine(arr2[0]);
        }

        static void aoba (string par){
            Console.WriteLine(par);
        }

        static string nome(string nome, string sobrenome) {
            return nome + " " + sobrenome;
        }
    }
}