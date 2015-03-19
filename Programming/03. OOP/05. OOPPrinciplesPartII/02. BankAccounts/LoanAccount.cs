
namespace _02.BankAccounts
{
    using System;

    public class LoanAccount : BankAccount
    {
        public LoanAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, BankAccountType.Loan, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.AccountCustomer.Type == CustomerType.Individual)
            {
                numberOfMonths -= 3;
            }

            if (this.AccountCustomer.Type == CustomerType.Company)
            {
                numberOfMonths -= 2;
            }

            return base.CalculateInterest(numberOfMonths);
        }
    }
}
