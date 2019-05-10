using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePizza
{
    class Pizza
    {
        private string nume;
        public PizzaBase baza = new PizzaBase();
       // public LinkedList<PizzaTopping>; // = new LinkedList<PizzaTopping>();
            public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                this.nume = Nume;
            }
        }
        public Pizza(): this("Piiza Special") { }
        public Pizza(string numele)
        {
            this.nume = numele;
        }
            public void AddTopping()
        {
            Console.WriteLine("Toping added");
        }
        public double CalculateTotalCost()
        {
            double cost = 25;
            return cost;
        }
        public void  PrintPizza()
        {
            Console.WriteLine("Pizza prints info: {0}",this.Nume);
        }
    }
}
