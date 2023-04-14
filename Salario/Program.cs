using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioA = new Funcionario();
            Funcionario funcionarioB = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário A: ");
            funcionarioA.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário A: ");
            funcionarioA.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário B: ");
            funcionarioB.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário B: ");
            funcionarioB.salario = double.Parse(Console.ReadLine());

            double media = (funcionarioA.salario + funcionarioB.salario) / 2;

            

        }
    }
}