using CarBusiness.Interfaces;

namespace CarBusiness.CarModels
{
    public class Producer : IProducer
    {
        public Producer(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
