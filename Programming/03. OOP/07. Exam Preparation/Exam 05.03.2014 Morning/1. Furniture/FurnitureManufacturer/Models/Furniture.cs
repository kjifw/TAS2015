
namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private const int defaultModelLength = 3;

        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = materialType.ToString();
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < defaultModelLength)
                {
                    throw new ArgumentException("Furniture model not in valid format.");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material.ToString();
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Furniture material cannot be null");
                }

                this.material = value;
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
                if (value <= 0.0m)
                {
                    throw new ArgumentOutOfRangeException("Furniture price cannot be less or equal to $0.00.");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0.0m)
                {
                    throw new ArgumentOutOfRangeException("Furniture height cannot be less or equal to 0.00 m.");
                }

                this.height = value;
            }
        }
    }
}
