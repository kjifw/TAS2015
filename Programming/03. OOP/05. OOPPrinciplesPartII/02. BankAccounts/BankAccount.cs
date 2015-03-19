
namespace _02.BankAccounts
{
    using System;
    using System.Text;

    public abstract class BankAccount
    {
        private Customer accountCustomer;
        private BankAccountType accountType;
        private decimal accountBalance;
        private decimal interestRate;

        public BankAccount(Customer cust, BankAccountType type, decimal balance, decimal interestRate)
        {
            this.AccountCustomer = cust;
            this.AccountType = type;
            this.AccountBalance = balance;
            this.InterestRate = interestRate;
        }

        public BankAccountType AccountType
        {
            get
            {
                return this.accountType;
            }
            private set
            {
                this.accountType = value;
            }
        }
        public Customer AccountCustomer
        {
            get
            {
                return this.accountCustomer;
            }
            private set
            {
                this.accountCustomer = value;
            }
        }
        public decimal AccountBalance
        {
            get
            {
                return this.accountBalance;
            }
            protected set
            {
                this.accountBalance = value;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount must be positive");
            }

            if (this.AccountType == BankAccountType.Deposit)
            {
                this.AccountBalance += amount;
            }
            else
            {
                this.AccountBalance -= amount;
            }
        }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            decimal result = numberOfMonths * ((this.InterestRate / 100) * this.AccountBalance);

            return result;
        }

        public override string ToString()
        {
            StringBuilder bankAccountInfo = new StringBuilder();

            bankAccountInfo.Append("customer:\n" + this.AccountCustomer);
            bankAccountInfo.Append("bank account type: " + this.AccountType + "\n");
            bankAccountInfo.AppendFormat("account balance: {0:C3}\n", this.AccountBalance);
            bankAccountInfo.AppendFormat("interest rate: {0:0.00%}\n", this.InterestRate / 100);

            return bankAccountInfo.ToString();
        }
    }
}
