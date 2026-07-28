using System;
public class Hospital
{
    public void tempurature()
    {
        float temp = 38.5f;
        if (temp > 39)
        {
            Console.WriteLine("high fever");
        }
        else if (temp > 38)
        {
            Console.WriteLine("fever");
        }
        else
        {
            Console.WriteLine("normal");
        }

    }
}