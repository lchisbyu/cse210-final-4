using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product("When Harry Met Sally - DVD", "DVD00134812-ENU", 12.99m, 1);
            Product product2 = new Product("Organic Celery", "F12930-123-1445", 4.99m, 5);
            Product product3 = new Product("Levi's 501 32x36 Relaxed Fit", "C1291-11-501P99", 71.99m, 2);

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
