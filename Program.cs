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

            var arr = new int[4];
            var arrb = arr; // São a mesma coisa, arr e arrb apontam pro mesmo lugar na memória.

            var arr1 = new int[4];
            var arr2 = new int[4];

            arr1[0] = arr2[0];
            arr1.CopyTo(arr2, 0); // Copia o conteúdo de arr1 para arr2.
        }

        public struct Funcionario
        {
            public int Id{ get; set; }
            public string Nome { get; set; }
        }
    }
}