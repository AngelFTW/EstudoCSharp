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

            Product mouse = new Product(1, "Mouse Gamer", 199.99, EProductType.Product);
            var manuntencaoEletrica = new Product(2,"Manuntencao eletrica", 500.00, EProductType.Service);

            Console.WriteLine(mouse.Id);            
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }

        struct Product{

            public Product(int id, string name, double price, EProductType type){

                Id = id;
                Name = name;
                Price = price;
                Type = type;

            }

            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;

            public double PriceInDolar(double dolar){
                return Price * dolar;
            }
        }

        static void aoba (string par){
            Console.WriteLine(par);
        }

        static string nome(string nome, string sobrenome) {
            return nome + " " + sobrenome;
        }

        enum EProductType{
            Product = 1,
            Service = 2
        }
    }
}