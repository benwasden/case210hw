using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public string GetName()
    {
        return _name;
    }

    public double CalculatePrice()
    {
        return (_price * _quantity);
    }
}