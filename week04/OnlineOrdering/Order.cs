using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class Order
{
    private double _domesticShipping = 5.00;
    private double _internationalShipping = 35.00;

    List<Product> _products = new List<Product>();
    Customer _customer = new Customer();
    Address _address = new Address();

    public Order()
    {
        // default constructor no parameters.
    }

    public string getAddress()
    {
        return _address.getAddress();
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _address.SetStreet(street);
        _address.SetCity(city);
        _address.SetStateProvince(state);
        _address.SetCountry(country);
    }
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void SetCustomer(string name)
    {
        _customer.SetName(name);
    }

    public string GetCustomer()
    {
        return _customer.GetName();
    }

    public void SetProduct(string name, string productId, double price, int quantity)
    {
        Product product = new Product();
        product.SetName(name);
        product.SetProductId(productId);
        product.SetPrice(price);
        product.SetQuantity(quantity);
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double sum = 0;
        foreach (Product product in _products)
        {
            sum += product.GetTotalCost();
        }
        return sum;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Order Packing Label");
        foreach (Product product in _products)
        {
            Console.WriteLine("Name: " + product.GetName() + ", ID: " + product.GetProductId() + ", Qty: " + product.GetQuantity() + ", Price: $" + product.GetPrice().ToString("F2"));
        }

        Console.WriteLine("Sub-Total Cost: $" + GetTotalCost().ToString("F2"));
        Console.WriteLine("Shipping Cost: $" + GetShippingCost().ToString("F2"));
        Console.WriteLine("Total Cost: $" + (GetTotalCost() + GetShippingCost()).ToString("F2"));
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Order Shipping Label");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_address.getAddress());
    }

    public double GetShippingCost()
    {
        if (_address.IsAddressUsa())
        {
            return _domesticShipping;
        }
        else
        {
            return _internationalShipping;
        }    
    }
}