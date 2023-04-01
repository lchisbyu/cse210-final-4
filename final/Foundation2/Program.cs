using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product("Product1", "P001", 2.99m, 10);
            Product product2 = new Product("Product2", "P002", 4.99m, 5);
            Product product3 = new Product("Product3", "P003", 1.99m, 20);

            // Create a customer
            Address address = new Address("123 Main St", "Bluffdale", "UT", "USA");
            Customer customer = new Customer("John Smith", address);

            // Create an order
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            Order order = new Order(customer, products);

            // Output the packing label and shipping label
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
        }
    }
}
