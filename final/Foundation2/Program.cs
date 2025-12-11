using System;

class Program
{
    static void Main(string[] args)
    {
        Address exampleAddress1 = new Address("123 Street", "Riverdale", "Utah", "USA");
        Customer exampleCustomer1 = new Customer("Bill", exampleAddress1);
        Product exampleProduct1 = new Product("Teddy bear", 9.99f, 1, "12390");
        Product exampleProduct2 = new Product("Toy train", 29.99f, 1, "23871");

        Order exampleOrder1 = new Order(exampleCustomer1);
        exampleOrder1.productListAdd(exampleProduct1);
        exampleOrder1.productListAdd(exampleProduct2);
        exampleOrder1.packingString();
        Console.WriteLine(exampleOrder1.shippingString());
        Console.WriteLine($"${exampleOrder1.afterShipping()}");

        Console.WriteLine();


        Address exampleAddress2 = new Address("456 Rojo", "Mexico City", "N/A", "Mexico");
        Customer exampleCustomer2 = new Customer("Jorge", exampleAddress2);
        Product exampleProduct3 = new Product("Bouquet", 20.99f, 1, "23908");
        Product exampleProduct4 = new Product("Shoes", 45.99f, 1, "90340");

        Order exampleOrder2 = new Order(exampleCustomer2);
        exampleOrder2.productListAdd(exampleProduct3);
        exampleOrder2.productListAdd(exampleProduct4);
        exampleOrder2.packingString();
        Console.WriteLine(exampleOrder2.shippingString());
        Console.WriteLine($"${exampleOrder2.afterShipping()}");
        


    }
}