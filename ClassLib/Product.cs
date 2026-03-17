using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Product
    {
        public string Article { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public int SupplierId { get; set; }
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }
        public int Discount { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public Product(string article, string name, string unit, double price, int supplierId, int manufacturerId, int categoryId, int discount, int amount, string description, string imagePath)
        {
            Article = article;
            Name = name;
            Unit = unit;
            Price = price;
            SupplierId = supplierId;
            ManufacturerId = manufacturerId;
            CategoryId = categoryId;
            Discount = discount;
            Amount = amount;
            Description = description;
            ImagePath = imagePath;
        }
    }
}
