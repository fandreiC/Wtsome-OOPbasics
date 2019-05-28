using System;

namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customerT, double balanceT, double interestRT) : base(customerT, balanceT, interestRT) { }        

        public override double InerestAmount(int nrOfMoths)
        {
            if (nrOfMoths < 0)
            {
                Console.WriteLine("Insert a positive number!");
                return 0;
            }
            int freeMonths = 0;
            if (Customer.CustomerType == CustomerType.Individuals)
                freeMonths = 3;
            if (Customer.CustomerType == CustomerType.Companies)
                freeMonths = 2;
            return InterestCalculator(freeMonths, nrOfMoths);

        }

        private double InterestCalculator(int freeMonths, int nrOfMonths)
        {
            if (nrOfMonths > 0 && nrOfMonths < freeMonths)
                return 0;
            else
                return base.InerestAmount(nrOfMonths - freeMonths);
        }
    }

}
