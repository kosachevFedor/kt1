using System;

class Building
{
    private string _address;

    public Building(string address)
    {
        _address = address;
    }

    public string Address { get { return _address; } }
}
