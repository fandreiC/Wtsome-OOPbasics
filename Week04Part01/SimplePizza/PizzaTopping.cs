using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePizza
{
    class PizzaTopping
    {
        public enum NameT
        {
            Cheese,Meat,Vegetable
        }
        public double Cost { get; set; }
        public void PrintBase()
        {
            Console.WriteLine($"Print Topping of Pizza : {this.Cost} ");
        }
    }
}
