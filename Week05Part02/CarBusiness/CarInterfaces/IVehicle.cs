namespace CarBusiness.Interfaces
{
    public interface IVehicle
    {
        IProducer Producer { get; }
        string Name { get; }
    }
}
