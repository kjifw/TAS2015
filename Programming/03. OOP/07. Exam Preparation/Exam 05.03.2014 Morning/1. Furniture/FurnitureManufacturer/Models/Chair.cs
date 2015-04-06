
namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Chair legs cannot be less than 0.");
                }

                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            StringBuilder chairInfo = new StringBuilder();

            chairInfo.AppendFormat("Type: {0}", this.GetType().Name);
            chairInfo.AppendFormat(", Model: {0}", this.Model);
            chairInfo.AppendFormat(", Material: {0}", this.Material);
            chairInfo.AppendFormat(", Price: {0:F2}", this.Price);
            chairInfo.AppendFormat(", Height: {0:F2}", this.Height);
            chairInfo.AppendFormat(", Legs: {0}", this.NumberOfLegs);

            return chairInfo.ToString();
        }
    }
}
