using System;

ShoppingCart cart = new ShoppingCart();

cart.AddItem();
cart.AddItem();
cart.AddItem();

Console.WriteLine(cart.ItemCount);


class ShoppingCart
{
    public int ItemCount { get; private set; }

    public ShoppingCart()
    {
        ItemCount = 0;
    }

    public void AddItem()
    {
        ItemCount++;
    }

    public void RemoveItem()
    {
        if (ItemCount > 0)
        {
            ItemCount--;
        }
    }
}