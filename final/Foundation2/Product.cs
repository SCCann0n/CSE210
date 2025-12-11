public class Product
{
    private string _name;

    private float _price;

    private int _quantity;

    private string _productID;

    public Product(string name, float price, int quantity, string productID)
    {
        _name = name;

        _price = price;

        _quantity = quantity;

        _productID = productID;
    }

    public float returnPrice()
    {
        return _price;
    }

    public string productName()
    {
        return _name;
    }

    public string productID()
    {
        return _productID;
    }
}