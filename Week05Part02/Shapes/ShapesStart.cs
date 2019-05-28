using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesStart
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
               new Circle(12),
            new Triangle(4,7),
            new Rectangle(5,6),
            new Circle(9),
            new Triangle(3,6),
            new Rectangle(8,5)
           };
            foreach (var shape in shapes)
            {
                Console.WriteLine($" Shape: {shape.GetType()} has surface of : {shape.CalculateSurface()}");
            }
            Console.ReadKey();
        }
    }
}
