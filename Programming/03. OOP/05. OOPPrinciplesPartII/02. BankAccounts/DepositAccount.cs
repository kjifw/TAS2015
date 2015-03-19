
namespace _02.BankAccounts
{
    using System;

    public class DepositAccount : BankAccount
    {
        public DepositAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, BankAccountType.Deposit, balance, interestRate)
        {

        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot withdraw negative amount");
            }

            this.AccountBalance -= amount;
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.AccountBalance >= 0 && this.AccountBalance < 1000)
            {
                this.InterestRate = 0;    
            }

            return base.CalculateInterest(numberOfMonths);
        }
    }
}
