using System;

namespace Arrays // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5];

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n");


            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario { Id = 1, Nome = "João" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
            }
        }

        public struct Funcionario
        {
            public int Id{ get; set; }
            public string Nome { get; set; }
        }
    }
}