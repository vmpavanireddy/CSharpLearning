using System;
class Cart
{
    private List<double> items = new List<double>();

    public void AddItem(double price)
    {
        items.Add(price);
    }

    public double GetTotal()
    {
        return items.Sum();
    }
}
class Program_31
{
    static void Main(string[] args)
    {
        Cart cart = new Cart();
        cart.AddItem(10.99);
        cart.AddItem(5.49);
        cart.AddItem(3.75);

        Console.WriteLine("Total: $" + cart.GetTotal());
    }
}