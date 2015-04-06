
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Company : ICompany
    {
        private const int defaultNameLength = 5;

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;

            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < defaultNameLength)
                {
                    throw new ArgumentOutOfRangeException("Company name cannot be empty, null or with less than 5 symbols.");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                if (value == null || value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Company registration number must be exactly 10 symbols.");
                }

                if (!this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentOutOfRangeException("Company registration number must contain only digits.");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                //ICollection<IFurniture> furnituresCopy = new List<IFurniture>();

                //foreach (var item in this.furnitures)
                //{
                //    furnituresCopy.Add(item);
                //}

                //furnituresCopy = furnituresCopy
                //    .OrderBy(x => x.Price)
                //    .ThenBy(x => x.Model)
                //    .ToList();

                //return furnituresCopy;

                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            StringBuilder furnitureCatalog = new StringBuilder();
            furnitureCatalog.Append(this.Name + " - ");
            furnitureCatalog.Append(this.RegistrationNumber + " - ");

            if (this.furnitures.Count >= 0)
            {
                if (this.furnitures.Count == 0)
                {
                    furnitureCatalog.Append("no");
                    furnitureCatalog.Append(" furnitures");
                }
                else if (this.furnitures.Count == 1)
                {
                    furnitureCatalog.Append("1");
                    furnitureCatalog.Append(" furniture");
                }
                else
                {
                    furnitureCatalog.Append(this.furnitures.Count);
                    furnitureCatalog.Append(" furnitures");
                }

                if (this.furnitures.Count > 0)
                {
                    this.furnitures = this.furnitures
                        .OrderBy(x => x.Price)
                        .ThenBy(x => x.Model)
                        .ToList();

                    foreach (var item in this.furnitures)
                    {
                        furnitureCatalog.AppendLine();
                        furnitureCatalog.Append(item);
                    }
                }
            }

            return furnitureCatalog.ToString();
        }

        private bool ContainsOnlyDigits(string str)
        {
            foreach (var ch in str)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
