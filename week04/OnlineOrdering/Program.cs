using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("Juan topo", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());   
        Console.WriteLine($"Total Cost: ${order1.GetTotalcost():F2}");

    }
}