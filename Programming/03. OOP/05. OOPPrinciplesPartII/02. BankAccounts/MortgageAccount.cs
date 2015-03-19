
namespace _02.BankAccounts
{
    using System;

    public class MortgageAccount : BankAccount
    {
        public MortgageAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, BankAccountType.Mortgage, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            decimal result = 0.0m;

            if (this.AccountCustomer is IndividualCustomer)
            {
                result = base.CalculateInterest(numberOfMonths - 6);
            }

            if (this.AccountCustomer is CompanyCustomer)
            {
                this.InterestRate /= 2;

                if (numberOfMonths <= 12)
                {
                    result = base.CalculateInterest(numberOfMonths);
                }
                else
                {
                    result = base.CalculateInterest(12);

                    this.InterestRate *= 2;
                    result += base.CalculateInterest(numberOfMonths - 12);
                }
            }

            return result;
        }
    }
}
