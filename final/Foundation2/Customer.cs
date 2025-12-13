public class Customer
{
    private string _name;

    private Address customerAddress;

    public Customer(string name, Address a)
    {
        _name = name;

        customerAddress = a;
    }

    public bool CustomerUSA()
    {
        return customerAddress.inUS();
    }

    public string CustomerName()
    {
        return _name;
    }

    public string theirAddress()
    {
        return customerAddress.GetAddress();
    }
}