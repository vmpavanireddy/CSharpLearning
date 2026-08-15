using System;
class MovieTicket
{
    public string MovieName { get; set; }
    public int Seats { get; private set; }

    public MovieTicket(string movieName, int seats)
    {
        MovieName = movieName;
        Seats = seats;
    }

    public void BookSeat()
    {
        if (Seats > 0)
        {
            Seats--;
            Console.WriteLine("Seat booked");
        }
        else
        {
            Console.WriteLine("House full");
        }
    }
}
class program_40
{
    static void Main(string[] args)
    {
    }
}