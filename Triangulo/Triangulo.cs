using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangulo
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}