using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}