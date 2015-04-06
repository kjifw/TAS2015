
namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Table length cannot be less than 0.");
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Table width cannot be less than 0.");
                }

                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            StringBuilder tableInfo = new StringBuilder();

            tableInfo.AppendFormat("Type: {0}", this.GetType().Name);
            tableInfo.AppendFormat(", Model: {0}", this.Model);
            tableInfo.AppendFormat(", Material: {0}", this.Material);
            tableInfo.AppendFormat(", Price: {0}", this.Price);
            tableInfo.AppendFormat(", Height: {0}", this.Height);
            tableInfo.AppendFormat(", Length: {0}", this.Length);
            tableInfo.AppendFormat(", Width: {0}", this.Width);
            tableInfo.AppendFormat(", Area: {0}", this.Area);

            return tableInfo.ToString();
        }
    }
}
