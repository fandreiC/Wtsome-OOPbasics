using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public enum CustomerType
    {
        Individuals, Companies
    }
    public class Customer
    {
        private CustomerType customerType;
        private string name;
        private string adress;
        private string phoneNr;
        public CustomerType CustomerType { get => customerType; set => customerType = value; }
        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string PhoneNr { get => phoneNr; set => phoneNr = value; }
        public Customer(CustomerType customerTy, string nume) : this(customerTy, nume, "Iasi", "07XX000999") { }
        public Customer(CustomerType custType, string name, string adresa, string phone)
        {
            this.customerType = custType;
            this.name = name;
            this.adress = adresa;
            this.phoneNr = phone;
        }
    }
}
