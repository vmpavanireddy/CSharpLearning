using System;
class Product
{
    public string Name { get; set; }
    public int Stock { get; private set; }

    public Product(string name, int stock)
    {
        Name = name;
        Stock = stock;
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine("Product sold");
        }
        else
        {
            Console.WriteLine("Not enough stock");
        }
    }
}
class Program_36
{
    static void Main(string[] args)
    {

    }
}