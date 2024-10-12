using System;
using System.Runtime.CompilerServices;

public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool Country()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FinalAddress()
    {
        string customerAddress = _address + "\n" + _city + ", " + _state + ", " + _country;
        return customerAddress;
    }
}