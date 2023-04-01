using System;

namespace ProductOrderingSystem
{
    public class Product
    {
        private string name;
        private string id;
        private decimal price;
        private int quantity;

        public Product(string name, string id, decimal price, int quantity)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get { return name; }
        }

        public string ID
        {
            get { return id; }
        }

        public decimal Price
        {
            get { return price; }
        }

        public int Quantity
        {
            get { return quantity; }
        }
    }
}
