using System.Collections.Generic;
using CarBusiness.Interfaces;

namespace CarBusiness.CarModels
{
    public class Client : IPerson
    {
        public string Name { get; }

        public List<IOrder> ordersOfPerson { get; }

        public Client(string name)
        {
            this.Name = name;
            ordersOfPerson = new List<IOrder>();
        }
        public void PrintClient()
        {
            System.Console.WriteLine($"Clientul : {this.Name} are comandate :" +
                $"{string.Join(" , ",ordersOfPerson)}");
            int a = 0;
            foreach (var order in ordersOfPerson)
            {                
                System.Console.WriteLine($"{++a}. {order.Vehicle} from {order.StoreName} ");
            }

        }
    }
}
