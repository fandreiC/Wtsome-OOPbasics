using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBusiness.Interfaces;

namespace CarBusiness.CarModels
{
    public class Car:IVehicle
    {
        public IProducer Producer { get; }
        public string Name { get; }        

        public Car(IProducer producer, string name)
        {
            Producer = producer;
            Name = name;
        }
    }
}
