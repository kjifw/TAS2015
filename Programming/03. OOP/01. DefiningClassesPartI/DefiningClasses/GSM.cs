
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        private const string defaultOwner = "No owner";
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple Inc.");

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery gsmBattery;
        private Display gsmDisplay;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0)
        {

        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null, null, null)
        {

        }

        public GSM(string model, string manufacturer, decimal price,
            string owner, Battery gsmBattery, Display gsmDisplay)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.GsmBattery = gsmBattery;
            this.GsmDisplay = gsmDisplay;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    this.owner = defaultOwner;
                }
                else
                {
                    this.owner = value;
                }
            }
        }
        public Battery GsmBattery
        {
            get
            {
                return this.gsmBattery;
            }
            set
            {
                this.gsmBattery = value;
            }
        }
        public Display GsmDisplay
        {
            get
            {
                return this.gsmDisplay;
            }
            set
            {
                this.gsmDisplay = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public void AddCallToHistory(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public void DeleteCallByNumber(Call callToDelete)
        {
            if (this.CallHistory.Any(x => x.DialedNumber == callToDelete.DialedNumber))
            {
                this.CallHistory.Remove(
                    this.CallHistory.Last(
                    x => x.DialedNumber == callToDelete.DialedNumber));
            }
        }

        public void DeleteLongesCall()
        {
            this.CallHistory.Remove(
                this.CallHistory.OrderBy(x => x.CallDuration).Last());
        }

        public decimal PriceOfCallHistory(decimal pricePerMinute)
        {
            if (pricePerMinute < 0)
            {
                throw new ArgumentOutOfRangeException("Price per minute must be positive");
            }

            decimal totalPrice = 0.0m;

            foreach (var item in this.CallHistory)
            {
                totalPrice += pricePerMinute * ((decimal)item.CallDuration.Seconds / 60);
            }

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder gsmInfo = new StringBuilder();

            gsmInfo.AppendFormat("Gsm model: {0}\n", this.Model);
            gsmInfo.AppendFormat("Gsm manufacturer: {0}\n", this.Manufacturer);

            gsmInfo.AppendFormat(
                string.Format(new CultureInfo("en-US"), "Price: {0:C}\n",
                this.Price));

            gsmInfo.AppendFormat("Gsm owner: {0}\n", this.Owner);
            gsmInfo.Append(this.GsmBattery);
            gsmInfo.Append(this.GsmDisplay);

            return gsmInfo.ToString();
        }
    }
}