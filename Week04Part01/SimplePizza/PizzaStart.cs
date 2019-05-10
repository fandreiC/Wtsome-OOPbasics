using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePizza
{
    public class PizzaStart
    {
        static void Main(string[] args)
        {
            ShowScreen();
        }
        public static void ShowScreen()
        {
            Console.WriteLine("\n ShowScreen of Simple Pizza \n");
            Pizza pi1 = new Pizza();
            pi1.PrintPizza();

            Console.ReadKey();
        }
    }
}
