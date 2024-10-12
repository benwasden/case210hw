using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        double finalCost = 0;

        foreach (Product product in _products)
        {
            double price = product.GetPrice();
            double quantity = product.GetQuantity();
            double totalItem = price * quantity;
            finalCost += totalItem;
        }

        double shippingCost = Shipping();
        finalCost += shippingCost;

        return Math.Round(finalCost, 2);
    }

    public double Shipping()
    {
        double shippingCost = 0;
        bool location = _customer.FromUSA();
        {
            if (location == true)
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }
            return shippingCost;
        }
    }

    public void AddProduct(Product item)
    {
        _products.Add(item);
    }
    
    public string PackingLabel()
    {
        string packLabel = ("Packing Label: \n");
        foreach (Product product in _products)
        {
            packLabel += ($"{product.GetName()}: ({product.GetProductID()})\n");
        }
        return packLabel;
    }

    public string ShippingLabel()
    {
        string customerName = _customer.GetCustomerName();
        string address = _customer.GetAddress();
        string shipLabel = ($"Shipping Label:\n{customerName}\n{address}");
        return shipLabel;
    }

    public string MakeTotalCost()
    {
        string totalCost = "Bill:\n-- Product - ProductID - Price - Quantity --\n";
        double totalPrice = TotalCost();
        foreach (Product product in _products)
        {
            totalCost += ($"{product.GetName()} ({product.GetProductID()}) - ${product.GetPrice()} x {product.GetQuantity()} = {product.CalculatePrice()}\n");            
        }

        totalCost += "Shipping: $" + Shipping() + "\n";
        totalCost += "Total Price: $" + TotalCost();

        return totalCost;
    }

    public void DisplayAll()
    {
        string shippingLabel = ShippingLabel();
        string packingLabel = PackingLabel();
        string finalCost = MakeTotalCost();

        Console.WriteLine();
        Console.WriteLine(shippingLabel);
        Console.WriteLine();
        Console.WriteLine(packingLabel);
        Console.WriteLine();
        Console.WriteLine(finalCost);
    }
}