using System;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, double balance, double interestrate) : base(customer, balance, interestrate)
        {
        }

        public override double InerestAmount(int nrOfMoths)
        {
            // return base.InerestAmount(nrOfMoths);
            if (nrOfMoths < 0)
            {
                Console.WriteLine("Insert a positive number!");
                return 0;
            }
            int freeMonths = 0;
            if (Customer.CustomerType == CustomerType.Individuals)
                freeMonths = 6;
            if (Customer.CustomerType == CustomerType.Companies)
                freeMonths = 12;
            return InterestCalculator(freeMonths, nrOfMoths);

        }

        private double InterestCalculator(int freeMonths, int nrOfMonths)
        {
            if (nrOfMonths > 0 && nrOfMonths < freeMonths)
                return (double)(base.InerestAmount(nrOfMonths)) / 2;
            else
                return base.InerestAmount(nrOfMonths);
        }
    }

}
