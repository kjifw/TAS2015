
namespace DefiningClasses
{
    using System;
    using System.Text;

    public class Battery
    {
        private const string defaultModel = "No model";

        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType typeOfBattery;

        public Battery(string model)
            : this(model, 0, 0, null)
        {

        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType? typeOfBattery)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeOfBattery = typeOfBattery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    this.model = defaultModel;
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle must have positive value");
                }

                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk must have positive value");
                }

                this.hoursTalk = value;
            }
        }
        public BatteryType? TypeOfBattery
        {
            get
            {
                return this.typeOfBattery;
            }
            set
            {
                if (value == null)
                {
                    this.typeOfBattery = BatteryType.None;
                }
                else
                {
                    this.typeOfBattery = (BatteryType)value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();

            batteryInfo.AppendLine("Battery information: ");
            batteryInfo.AppendFormat("Model: {0}\n", this.Model);
            batteryInfo.AppendFormat("Hours idle: {0}\n", this.HoursIdle);
            batteryInfo.AppendFormat("Hours talk: {0}\n", this.HoursTalk);
            batteryInfo.AppendFormat("Battery type: {0}\n", this.TypeOfBattery);

            return batteryInfo.ToString();
        }
    }
}
