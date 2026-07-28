using System;
public class Cricket
{
    public void runs()
    {
        int runs = 48;
        if (runs >= 100)
        {
            Console.WriteLine("Century");
        }
        else if (runs >= 50)
        {
            Console.WriteLine("half Century");
        }
        else{
            Console.WriteLine("keep batting");
        }

    }
}