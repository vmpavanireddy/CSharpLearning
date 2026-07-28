using System;
public class Countdown
{
    public void go()
    {
        //revrese countdown from 10 to 0
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Blast off!");
    }
}