using System;
public class Shopping
{
    public void cart()
    {

        int org = 250;
        int disc = 0;
        int final = 0;
        if (org > 200)
        {
            disc = 20;
        }
        final = org - disc;
        Console.WriteLine("original price: " + org);
        Console.WriteLine("discount: " + disc);
        Console.WriteLine("final price: " + final);
    }
}
