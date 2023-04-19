using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}