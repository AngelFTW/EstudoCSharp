using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Entre os dados do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Console.WriteLine("Dados do Produto: " + p); 

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(quantidade);

            Console.WriteLine("Dados Atualizados: " + p);


        }
    }
}