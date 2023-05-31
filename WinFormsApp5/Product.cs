using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public class Product
    {
        private string? _description;
        private double _price;
        private string? _productName;

        public double Price { get => _price; }
        public string? ProductName { get => _productName; }
        public string? Description { get => _description; }

        public Product() { }

        public Product(string productName, string description, double price)
        {
            _description = description;
            _price = price;
            _productName = productName;
        }
    }
}
