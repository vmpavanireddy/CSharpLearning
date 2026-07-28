using System;
public class E_Commerce
{
    public void membership()
    {
        bool member = true;
        int amt = 120;
        int delivery = 0;
        if (member && amt > 100)
        {
            Console.WriteLine("free delivery ");
        }
        else
        {
            delivery = 10;
        }
        Console.WriteLine("Delivery Charge: " + delivery);
    }
}
