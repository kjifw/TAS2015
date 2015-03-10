
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Call
    {
        private string date;
        private string time;
        private string dialedNumber;
        private TimeSpan callDuration;

        public Call(DateTime date, string dialedNumber, TimeSpan callDuration)
        {
            this.Date = date.ToShortDateString();
            this.time = date.ToShortTimeString();
            this.DialedNumber = dialedNumber;
            this.callDuration = callDuration;
        }

        public string Date
        {
            get 
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                this.dialedNumber = value;
            }
        }
        public TimeSpan CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException("Duration of the call must be positive");
                }

                this.callDuration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder currentCall = new StringBuilder();

            currentCall.AppendFormat("Call date: {0}\n", this.Date);
            currentCall.AppendFormat("Call time: {0}\n", this.Time);
            currentCall.AppendFormat("Dialed number: {0}\n", this.DialedNumber);
            currentCall.AppendFormat("Call duration in seconds: {0}\n", this.CallDuration);

            return currentCall.ToString();
        }
    }
}
