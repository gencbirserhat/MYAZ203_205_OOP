using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Lab
{
    public class Product : IProduct, IComparable<Product>
    {
        private int _productId;
        private string? _productName;
        private decimal _unitPrice;
        private short _unitsInStock;

        private List<Product> _products;

        public Product()
        {
            _products = new List<Product>();
        }

        public Product(List<Product> products)
        {
            _products = products;
        }

        public Product(int productId, string productName, decimal unitPrice, short unitsInStock)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        public int ProductId 
        { 
            get => _productId; 
            set => _productId = value; 
        }
        public string ProductName 
        { 
            get => _productName; 
            set => _productName = value; 
        }
        public decimal UnitPrice 
        { 
            get => _unitPrice; 
            set => _unitPrice = value; 
        }
        public short UnitsInStock 
        { 
            get => _unitsInStock; 
            set => _unitsInStock = value; 
        }

        public int CompareTo(Product? other)
        {
            return this.UnitPrice.CompareTo(other.UnitPrice);
        }

        public void GetProduct()
        {
            _products.Sort();
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"{_products[i]._productId} {_products[i]._productName} {_products[i]._unitPrice} {_products[i]._unitsInStock}");
            }
        }

        public decimal GetUnitPrice(int id)
        {
            throw new NotImplementedException();
        }
    }
}
