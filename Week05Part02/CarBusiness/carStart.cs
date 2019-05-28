using CarBusiness.Interfaces;
using CarBusiness.CarModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    class carStart
    {
        static void Main(string[] args)
        {
            ClientStart();
            Console.ReadKey();
        }
        static void ClientStart()
        {
            var Alex = new Client("Alex");
            var FordMagazin = new FordStore();
            FordMagazin.EnterStore(Alex);
            var AlexOrder1 = new Order();
            AlexOrder1=(Order)FordMagazin.Buy(Alex,"Focus");
            Alex.PrintClient();
            var AlexOrder3 = new Order();
            AlexOrder3 = (Order)FordMagazin.Buy(Alex, "Fiesta");
            Alex.PrintClient();

            var SkodaMagazin = new SkodaStore();
            SkodaMagazin.EnterStore(Alex);
            var AlexOrder2 = new Order();
            AlexOrder2 = (Order)SkodaMagazin.Buy(Alex, "Fabia");

            Alex.PrintClient();
            FordMagazin.cancelOrder(Alex,AlexOrder3);
            Alex.PrintClient();



        }

        
    }
}
