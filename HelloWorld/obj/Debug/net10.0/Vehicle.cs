using System;
vehicle = new Car();
vehicle.Move();
class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("Vehicle is moving");
    }
}
class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car drives on the road");
    }
}
class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Airplane flies in the sky");
    }
}
class Boat : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Boat sails on water");
    }
}