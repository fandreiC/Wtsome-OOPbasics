using System;
using System.Collections.Generic;
using CarBusiness.Interfaces;

namespace CarBusiness.CarModels
{
    public class FordStore : IStore
    {
        public FordStore()
        {
            Name = "Ford";
        }
        public string Name { get; }

        private List<IVehicle> cars = new List<IVehicle>
        {
            new Car(new Producer("Ford"), "Focus"),
            new Car(new Producer("Ford"), "Mondeo"),
            new Car(new Producer("Ford"), "Fiesta"),
        };

        private List<IOrder> fordOrders = new List<IOrder>();

        public void EnterStore(IPerson person)
        {
            Console.WriteLine("Person {0} enters Store Ford ",person.Name);
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
                DeliveryDate = DateTime.Now.AddDays(28),
                StoreName = this.Name
            };

            fordOrders.Add(order);
           
            person.ordersOfPerson.Add(order);
            

            return order;
        }

        public void cancelOrder(IPerson person, IOrder order)
        {
           
            int index = fordOrders.FindIndex(a => a.RefNumber == order.RefNumber);

            fordOrders = fordOrders[0].Cancel(fordOrders,index);
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
