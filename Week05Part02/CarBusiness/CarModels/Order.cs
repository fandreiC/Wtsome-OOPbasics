using System;
using System.Collections.Generic;
using CarBusiness.Interfaces;

namespace CarBusiness.CarModels
{
    public class Order : IOrder
    {
        public string RefNumber { get; set; }

        public string StoreName { get; set; }

        public IVehicle Vehicle { get; set; }

        public DateTime DeliveryDate { get; set; }
        public static int count = 0;
        public Order()
        {
            count++;
            RefNumber = String.Concat(" ",count);
        }

        public List<IOrder> Cancel(List<IOrder> lista,int idx)
        {
            //throw new NotImplementedException();
            lista.RemoveAt(idx);
            return lista;            

        }
    }
}
