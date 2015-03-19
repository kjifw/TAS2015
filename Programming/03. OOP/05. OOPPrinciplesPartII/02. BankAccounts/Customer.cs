
namespace _02.BankAccounts
{
    using System;
    using System.Text;

    public abstract class Customer
    {
        private string customerName;
        private CustomerType type;

        public Customer(string name, CustomerType type)
        {
            this.CustomerName = name;
            this.Type = type;
        }

        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
            private set
            {
                this.customerName = value;
            }
        }
        public CustomerType Type
        {
            get 
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder customerInfo = new StringBuilder();

            customerInfo.Append("name: " + this.CustomerName + "\n");
            customerInfo.Append("type: " + this.type + "\n");

            return customerInfo.ToString();
        }
    }
}
