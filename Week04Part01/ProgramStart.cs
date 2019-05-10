using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikHomework1;
using HotelApp;
using SimplePizza;


namespace Week04Part01
{
     class ProgramStart
    {
        static void Main(string[] args)
        {
            StartScreen();

            
        }
        static void StartScreen()
        {
            Console.Clear();
            int opt;
            bool check;
            int[] optiuni = new int[] { 0, 1, 2, 3 };
            LinkedList<int> listaOptiuni = new LinkedList<int>(optiuni);
            do
            {
                Console.WriteLine(@"OOP WEEK 04 Options Are : 
                    0. Exit
                    1. Telerik Academy Homework 1
                    2. EX3 from course: Model a simple Hotel app
                    3. EX4 from course: Model a simple Pizza app" );
                check = int.TryParse(Console.ReadLine(),out opt);
                if (!listaOptiuni.Contains(opt))
                    check = false;
            } while (!check);

            switch (opt)
            {
                case 0: return;
                case 1: TelerikApp.ShowScreen();
                    break;
                case 2: HotelStart.ShowScreen();
                    break;
                case 3:
                    PizzaStart.ShowScreen();
                    break;
            }
            
        }
    }
}
