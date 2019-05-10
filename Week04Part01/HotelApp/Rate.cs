using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Rate
    {
        private double amount;
        public const string cUrrency= "Lei";

        public double Amount { get; set; }

        public Rate() : this(1500) { }
        public Rate(double rate )
        {
            Amount = rate;
        }
        public void printRate()
        {
            Console.WriteLine($"Room is {this.amount} {cUrrency} ");
            Console.WriteLine("Room is : {0:c2} ",this.amount);
        }
    }
}
