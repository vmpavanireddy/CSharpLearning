using System;
public class Password
{
    public void length()
    {
        int pass = 8;
        if (pass >= 12)
        {
            Console.WriteLine("strong");
        }
        else if (pass > 8)
        {
            Console.WriteLine("medium");
        }
        else{
            Console.WriteLine("weak");
        }

    }
}