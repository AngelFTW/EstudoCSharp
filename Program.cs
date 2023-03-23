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

            do
            {
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


            //Guids
            var id = Guid.NewGuid(); // Diferente do debaixo
            id = new Guid("aadb97a59c56040772603c597490d729");
            id.ToString().Substring(0, 8);

            if(id == Guid.NewGuid())
                id.ToString().Substring(0, 8);


            // interpolacao
            var price = 10.2;
            var texto = "Preco do produto eh " + price;

            var text1 = string.Format(@"O preco do produto 
            eh {0} apenas na promocao {1}", price, true);
            var texto3 = $"o preco do produto é {price}";


            //Comparacao de Strings
            var texto4 = "Algo Testando importante"; //Case sensitive
            Console.WriteLine(texto4.CompareTo("Testando"));
            Console.WriteLine(texto4.Contains("testando",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto4.StartsWith("Algo"));
            Console.WriteLine(texto4.EndsWith("importante"));
            Console.WriteLine(texto4.Equals("Algo Testando importante"));
            
        }

        struct Product
        {

            public Product(int id, string name, double price, EProductType type)
            {

                Id = id;
                Name = name;
                Price = price;
                Type = type;

            }

            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }

        static void aoba (string par)
        {
            Console.WriteLine(par);
        }

        static string nome(string nome, string sobrenome) 
        {
            return nome + " " + sobrenome;
        }

        enum EProductType
        {
            Product = 1,
            Service = 2
        }
    }
}