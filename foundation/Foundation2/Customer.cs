using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool FromUSA()
    {
        bool location = _address.Country();
        return location;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.FinalAddress();
    }
}