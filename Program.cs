using System;

namespace Calculadora // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
        
        }

        static void Menu(){

            Console.WriteLine("Qual operação deseja fazer? \n 1 - Soma \n 2 - Subtracao \n 3 - Divisao \n 4 - Multiplicacao \n 5 - Sair \n ------------------- \n Selecione uma opcao:");
            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Divisao();
                    break;

                case 4:
                    Multiplicacao();
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;    
                default:
                    Console.WriteLine("Numero Invalido");
                    Menu();
                    break;
            }
            }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}\n");
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtracao é " + resultado);
            Console.WriteLine($"O resultado da subtracao é {resultado}\n");
            Menu();
        }

        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("O resultado da divisao é " + resultado);
            Console.WriteLine($"O resultado da divisao é {resultado}\n");
            Menu();
        }    
    
        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("O resultado da subtracao é " + resultado);
            Console.WriteLine($"O resultado da subtracao é {resultado}\n");
            Menu();
        }
    
        
    }
}