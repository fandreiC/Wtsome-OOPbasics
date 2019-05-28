namespace CarBusiness.Interfaces
{
    public interface IStore
    {
        string Name { get; }
        void EnterStore(IPerson person);
        IOrder Buy(IPerson person,string carName);
        void cancelOrder(IPerson person,IOrder order);

    }
}
