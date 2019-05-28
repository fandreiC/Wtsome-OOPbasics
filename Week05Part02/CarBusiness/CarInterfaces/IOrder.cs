using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness.Interfaces
{
    public interface IOrder
    {
        string RefNumber { get; set; }
        string StoreName { get; set; }
        IVehicle Vehicle { get; set; }
        DateTime DeliveryDate { get; set; }

       List<IOrder> Cancel(List<IOrder> listaOrders,int idx);
    }
}
