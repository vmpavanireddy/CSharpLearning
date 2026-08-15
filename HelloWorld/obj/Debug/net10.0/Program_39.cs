using System;
class ShoppingCart
{
    public double Total { get; set; }

    public double GetFinalPrice()
    {
        if (Total >= 5000)
            return Total * 0.80;

        if (Total >= 2000)
            return Total * 0.90;

        return Total;
    }
}
class Program_39
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        cart.Total = 6000;

        Console.WriteLine(cart.GetFinalPrice()); // 4800
    }
}