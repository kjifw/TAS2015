
namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal convertedStateHeight = 0.1m;

        private bool isConverted = false;
        private decimal defaultHeight;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {

        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            if (IsConverted)
            {
                this.IsConverted = false;
                this.Height = this.defaultHeight;
            }
            else
            {
                this.defaultHeight = this.Height;

                this.IsConverted = true;
                this.Height = convertedStateHeight;
            }
        }

        public override string ToString()
        {
            StringBuilder convertableChairInfo = new StringBuilder();

            convertableChairInfo.Append(base.ToString());
            convertableChairInfo.Append(", State: ");

            if (this.IsConverted)
            {
                convertableChairInfo.Append("Converted");    
            }
            else
            {
                convertableChairInfo.Append("Normal");
            }

            return convertableChairInfo.ToString();
        }
    }
}
