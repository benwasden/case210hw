using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("1234 Speedway Drive", "San Jose", "CA", "USA");
        Customer customer1 = new Customer("Steve Watcher", address1);
        List<Product> products1 = new List<Product>();

        Product product101 = new Product("Nintendo Switch", "564AB2", 299.99, 1);
        Product product102 = new Product("Switch Controller", "A563CG", 69.99, 2);
        Product product103 = new Product("Switch Games", "56123A", 59.99, 5);

        products1.Add(product101);
        products1.Add(product102);
        products1.Add(product103);

        Order order1 = new Order(products1, customer1);

        Console.WriteLine("First Order:");
        order1.DisplayAll();
        Console.WriteLine();


        Address address2 = new Address("52 Bodrington Court", "Markham", "Ontario", "Canada");
        Customer customer2 = new Customer("Ben Brigham", address2);
        List<Product> products2 = new List<Product>();

        Product product201 = new Product("Hotel Night", "ABC123", 159.44, 4);
        Product product202 = new Product("Toothpaste", "YB492C", 2.99, 1);
        Product product203 = new Product("Breakfast", "BR4KFS", 12.57, 3);
        Product product204 = new Product("Uber", "UB3R67", 20.53, 9);

        products2.Add(product201);
        products2.Add(product202);
        products2.Add(product203);
        products2.Add(product204);

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Second Order:");
        order2.DisplayAll();
        Console.WriteLine();


        Address address3 = new Address("512 Salt Lake Court", "Salt Lake City", "Utah", "USA");
        Customer customer3 = new Customer("Allison Glenn", address3);
        List<Product> products3 = new List<Product>();

        Product product301 = new Product("Shampoo", "CL34ND", 3.99, 3);
        Product product302 = new Product("Soap", "H4NDS12", 2.95, 4);
        Product product303 = new Product("Deodorant", "N1C3J0B", 5.01, 1);

        products3.Add(product301);
        products3.Add(product302);
        products3.Add(product303);

        Order order3 = new Order(products3, customer3);

        Console.WriteLine("Third Order");
        order3.DisplayAll();
    }
}