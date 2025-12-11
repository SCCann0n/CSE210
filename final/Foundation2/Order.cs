public class Order
{
    private List<Product> products = new List<Product>();

    private Customer theCustomer;

    public Order(Customer c)
    {
        theCustomer = c;
    }

    public void productListAdd(Product p)
    {
        products.Add(p);
    }

    public float beforeShipping()
    {

        float total = 0;

        foreach (Product p in products)
        {
            total += p.returnPrice();
        }
        
        return total;
    }

    public float afterShipping()
    {

        float subtotal = beforeShipping();

        float shippingCost = 0;

        if (theCustomer.CustomerUSA())
        {
            shippingCost = 5.00f;
        }

        else
        {
            shippingCost = 35.00f;
        }

        float totalAfterShipping = shippingCost + subtotal;

        return totalAfterShipping;
    }

    public void packingString()
    {
        foreach (Product p in products)
        {
            Console.Write($"{p.productName()} ");
            Console.WriteLine($"{p.productID()}");
        }
    }

    public string shippingString()
    {
        return $"{theCustomer.CustomerName()}, {theCustomer.theirAddress()}";
    }
}