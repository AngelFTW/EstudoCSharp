using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            

            Console.WriteLine("Area de X = " + x.Area().ToString("F4"));
            Console.WriteLine("Area de Y = " + y.Area().ToString("F4"));

            

            double raio = double.Parse(Console.ReadLine());

            

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            
        }
        
    }
}