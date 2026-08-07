using System;
class Vehicle_1
{
    public string Brand { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}
class Car : Vehicle_1
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}
class Bike : Vehicle_1
{
    public void Ride()
    {
        Console.WriteLine("Bike is riding");
    }
}
class Program_6
{
    static void Main()
    {
        Car car = new Car();

        car.Brand = "Toyota";
        car.Start();
        car.Drive();

        Console.WriteLine();

        Bike bike = new Bike();

        bike.Brand = "Yamaha";
        bike.Start();
        bike.Ride();
    }
}