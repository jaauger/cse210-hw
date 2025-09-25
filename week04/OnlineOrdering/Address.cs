using System.Security.Cryptography.X509Certificates;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address()
    {
        // Default Constructor no paramters
    }

    public Address(String street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateProvince(string state)
    {
        _stateProvince = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    public string getAddress()
    {
        string customerAddress = "";
        customerAddress += _street + "\n";
        customerAddress += _city + "\n";
        customerAddress += _stateProvince + "\n";
        customerAddress += _country;

        return customerAddress;
    }

    public bool IsAddressUsa()
    {
        if (_country == "USA" || _country == "US" || _country == "usa" || _country == "us")
            return true;
        else
        {
            return false;
         }    
    }
}   