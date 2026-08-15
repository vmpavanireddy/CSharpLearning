using System;
class Car
{
    public string Model { get; set; }
    public double Fuel { get; private set; }

    public Car(string model, double fuel)
    {
        Model = model;
        Fuel = fuel;
    }

    public void Drive(double distance)
    {
        double fuelNeeded = distance / 10;

        if (fuelNeeded <= Fuel)
        {
            Fuel -= fuelNeeded;
            Console.WriteLine("Car is driving");
        }
        else
        {
            Console.WriteLine("Not enough fuel");
        }
    }
}
class Program_37
{
    static void Main(string[] args)
    {

    }
}