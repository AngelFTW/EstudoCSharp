using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetodoAbstrato.Entities.Enums;


namespace MetodoAbstrato.Entities
{
    public class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}