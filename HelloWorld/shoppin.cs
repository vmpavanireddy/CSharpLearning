using System;
class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} - ${Price}");
    }
}
class shoppin
{
    static void Main(string[] args)
    {
        Product laptop = new Product("Laptop", 999.99);

        laptop.Display();
    }
}