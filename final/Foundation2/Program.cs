using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        var customer1 = new Customer { Name = "Sive Jola", Address = new Address { Street = "4763 Tabatha Street", City = "Cape town", State = "CA", Country = "South Africa" } };
        var order1 = new Order(customer1);
        order1.AddProduct(new Product { Name = "Product 1", ProductId = 1, Price = 25.00, Quantity = 2 });
        order1.AddProduct(new Product { Name = "Product 2", ProductId = 2, Price = 29.99, Quantity = 1 });

        var customer2 = new Customer { Name = "David Smith", Address = new Address { Street = "4832 Zone 1 St", City = "Harare", State = "HR", Country = "Zimbabwe" } };
        var order2 = new Order(customer2);
        order2.AddProduct(new Product { Name = "Product 3", ProductId = 3, Price = 18.99, Quantity = 3 });
        order2.AddProduct(new Product { Name = "Product 4", ProductId = 4, Price = 59.99, Quantity = 1 });

        var orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine($"Total cost: ${order.GetTotalCost()}");
            Console.WriteLine("Packing label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
        }
    }
}
