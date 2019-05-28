using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class BankStart
    {
        static void Main(string[] args)
        {
            ShowStart();
            Console.ReadKey();
        }
        private static void ShowStart()
        {
            Customer customer2 = new Customer(CustomerType.Individuals,"Alex","Vaslui","074-5454 55");
            Customer customer3 = new Customer(CustomerType.Companies, "Bogdan", "Suceava", "075-67676 33");

            Account[] accounts = new Account[]
            {
                new DepositAccount(customer2,700,40),
                new DepositAccount(customer3,700,40),
                new DepositAccount(new Customer(CustomerType.Individuals,"Andrei"),500,30),
                new DepositAccount(new Customer(CustomerType.Companies,"SC fly SRL","Brasov","0787788745"),4000,50),
                new LoanAccount(customer2,600,40),
                new LoanAccount(customer3,800,50),
                new LoanAccount(new Customer(CustomerType.Individuals,"Alina"),650,25),
                new MortgageAccount(customer2,1000,20),
                new MortgageAccount(customer3,1000,20),
                new MortgageAccount(new Customer(CustomerType.Companies,"SC RealR SA"),600,3)
            };

            ShowBankStart banker = new ShowBankStart();
            banker.PrintMoney(accounts);
            DepositAccount depositsForCustomer2 = new DepositAccount(customer2, 5500, 35);
            DepositAccount depositsForCustomer3 = new DepositAccount(customer3, 3500, 45);
            depositsForCustomer2.WithDraw(700);
            depositsForCustomer2.Deposit(555);
            banker.PrintMoney(depositsForCustomer2);
            depositsForCustomer3.WithDraw(700);
            depositsForCustomer3.Deposit(555);
            banker.PrintMoney(depositsForCustomer3);

        }
    }
    public class ShowBankStart : IPrinter
    {
        public  void PrintMoney(Account[] accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine("{0}-{5} , Name: {1} , Adress: {2} , PhoneNr: {3} ,InterestAmount:{4} ",
                    account.GetType(),account.Customer.Name,account.Customer.Adress,account.Customer.PhoneNr,account.InerestAmount(7),account.Customer.CustomerType);
                
            }
            Console.WriteLine("\n"); ;
        }
        public void PrintMoney(Account account)
        {
            Console.WriteLine("{0}-{5} , Name: {1} , Adress: {2} , PhoneNr: {3} ,InterestAmount:{4} ",
                    account.GetType(), account.Customer.Name, account.Customer.Adress, account.Customer.PhoneNr, account.InerestAmount(7), account.Customer.CustomerType);
        }
    }
    public interface IPrinter
    {
        void PrintMoney(Account[] accounts);
        void PrintMoney(Account account);
    }
}
