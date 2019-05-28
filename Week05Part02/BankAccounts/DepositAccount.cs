using System;

namespace BankAccounts
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, double balance, double interestrate) : base(customer, balance, interestrate)
        {
        }

        public override double InerestAmount(int nrOfMoths)
        {
            if (this.Balance >= 0 && this.Balance <= 1000)
                return 0;
            else if (base.Balance > 1000)
                return base.InerestAmount(nrOfMoths);
            else return 1;

        }

        public void WithDraw(double moneyTOwithdraw)
        {
            if (moneyTOwithdraw > this.Balance)
                Console.WriteLine("Not enough money in your account!! ");
            else
            if (moneyTOwithdraw <= 0)
                Console.WriteLine("Insert a positive amount!!");
            else
            {
                Console.Write("Initial /balance is : {0} ",this.Balance);
                this.Balance -= moneyTOwithdraw;
                Console.WriteLine("withDraw {0} from account! Balance now is : {1}", moneyTOwithdraw, this.Balance);
            }
        }
    }

}
