using System.Collections.Generic;

namespace CarBusiness.Interfaces
{
    public interface IPerson
    {
        string Name { get; }
        List<IOrder> ordersOfPerson{get;}
    }
}
