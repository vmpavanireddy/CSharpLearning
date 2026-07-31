using System;

class Product_1
{
    private double _price;

    public double Price
    {
        get { return _price; }
        set
        {
            if (value > 0)
                _price = value;
            else
                Console.WriteLine("Invalid price!");
        }
    }
}