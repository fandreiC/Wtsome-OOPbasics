using System;
using System.Collections.Generic;
using CarBusiness.Interfaces;

namespace CarBusiness.CarModels
{
    public class SkodaStore : IStore
    {
        public SkodaStore()
        {
            Name = "Skoda";
        }
        public string Name { get; }

        private List<IVehicle> cars = new List<IVehicle>
        {
            new Car(new Producer("Skoda"), "Rapid"),
            new Car(new Producer("Skoda"), "Octavia"),
            new Car(new Producer("Skoda"), "Fabia"),
        };

        private List<IOrder> skodaOrders = new List<IOrder>();

        public void EnterStore(IPerson person)
        {
            Console.WriteLine("Person {0} enters Store Skoda ", person.Name);
        }

        public IOrder Buy(IPerson person, string carName)
        {
            var currentCar = FindCar(carName);

            if (currentCar == null)
            {
                return null;
            }

            var order = new Order
            {
                Vehicle = currentCar,
                DeliveryDate = DateTime.Now.AddDays(21),
                StoreName = this.Name
            };

            skodaOrders.Add(order);

            return order;
        }

        public void cancelOrder(IPerson person, IOrder order)
        {
            //throw new System.NotImplementedException();

            int index = skodaOrders.FindIndex(a => a.RefNumber == order.RefNumber);

            skodaOrders = skodaOrders[0].Cancel(skodaOrders, index);
        }

        private IVehicle FindCar(string carToFind)
        {
            foreach (var car in cars)
            {
                if (car.Name == carToFind)
                {
                    return car;
                }
            }

            return null;
        }
    }
}
