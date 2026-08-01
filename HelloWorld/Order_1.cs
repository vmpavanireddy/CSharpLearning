using System;

class Order_1
{
    public int OrderId { get; private set; }
    private double balance;

public double Balance
{
    get
    {
        return balance;
    }
}

    public Order_1(int id)
    {
        OrderId = id;
        balance = 0.0;
    }
}