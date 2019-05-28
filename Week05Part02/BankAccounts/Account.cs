using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private double balance;
        private double interestRAte;

        public Account(Customer customer, double balance, double interestrate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRAte = interestrate;
        }

        public double InterestRAte { get => interestRAte; set => interestRAte = value; }
        public double Balance { get => balance; set => balance = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        public virtual double InerestAmount(int nrOfMoths)
        {
            return (double)nrOfMoths * interestRAte;
        }
        public void Deposit(double moneyTOdeposit)
        {
            Console.Write("Initial /balance is : {0} ", this.Balance);
            if (moneyTOdeposit <= 0)
            {
                Console.WriteLine("Enter a positive amount!! ");
            }
            else
            {
                this.Balance += moneyTOdeposit;
            }
            Console.WriteLine(" deposit: {0} , Now Balanace is : {1}", moneyTOdeposit,this.Balance);
        }
    }

}
