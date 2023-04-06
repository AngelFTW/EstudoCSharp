using System;

namespace Execptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nao existe esse indice");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Deu um erro ai");
            }
            //Tratar os erros dos mais especificos ate os mais genericos;

            finally
            {
                Console.WriteLine("Fim do programa");
            }
        }
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new Exception("O texto nao pode ser vazio");
            }
        }
        public class MinhaException : Exception
        {
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}