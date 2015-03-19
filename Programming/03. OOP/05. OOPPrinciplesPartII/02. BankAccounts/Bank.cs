
namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private string bankName;
        private List<BankAccount> accounts = new List<BankAccount>();

        public Bank(string name)
        {
            this.BankName = name;
        }

        public string BankName
        {
            get
            {
                return this.bankName;
            }
            private set
            {
                this.bankName = value;
            }
        }

        public void AddAccount(BankAccount acc)
        {
            this.accounts.Add(acc);
        }

        public void AddMultipleAccounts(List<BankAccount> acc)
        {
            this.accounts.AddRange(acc);
        }

        public void RemoveAccount(BankAccount acc)
        {
            this.accounts.Remove(acc);
        }

        public override string ToString()
        {
            StringBuilder bankInfo = new StringBuilder();

            bankInfo.AppendLine("bank name: " + this.BankName);
            foreach (var item in this.accounts)
            {
                bankInfo.Append(item);
            }

            return bankInfo.ToString();
        }
    }
}
