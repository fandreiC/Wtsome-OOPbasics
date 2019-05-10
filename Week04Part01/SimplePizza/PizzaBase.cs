using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePizza
{
    class PizzaBase
    {
        public enum Name
        {
            Regual, Thick,Italian
        }
        public double Cost { get; set; }
        public void PrintBase()
        {
            Console.WriteLine($"Print Base of Pizza : {this.Cost} ");
        }
    }
}
