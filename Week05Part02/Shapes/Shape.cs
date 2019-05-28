using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        private int width;
        private int height;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public Shape(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public abstract double CalculateSurface();

    }
    class Triangle : Shape
    {
        public Triangle(int height, int width) : base(height, width) { }

        public override double CalculateSurface()
        {
            return (double)Height * (Width / 2);
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width) { }

        public override double CalculateSurface()
        {
            return (double)Width * Height;
        }
    }
    class Circle : Shape
    {
        public Circle(int raza) : base(raza,raza) { }
        public override double CalculateSurface()
        {
            return (double)Height * Width;
        }
    }
}
