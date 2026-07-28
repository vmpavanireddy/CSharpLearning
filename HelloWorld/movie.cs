using System;
public class Movie
{
    public void movietheatre()
    {

        bool ticketAvailable = true;
        int age = 19;
        if (ticketAvailable && age >= 18)
        {
            Console.WriteLine("Enjoy the Movie!");
        }
        else
        {
            Console.WriteLine("Entry Denied");
        }
    }
}