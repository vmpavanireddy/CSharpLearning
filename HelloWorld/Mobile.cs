using System;
public class Mobile
{
    public void Recharge()
    {
        int amt = 99;
        if (amt > 499)
        {
            Console.WriteLine("Gold membership");
        }
        else if (amt > 299)
        {
            Console.WriteLine("silver membership");
        }
        else if (amt > 99)
        {
            Console.WriteLine("bronze membership");
        }
        else
        {
            Console.WriteLine("basic membership");
        }

    }
}