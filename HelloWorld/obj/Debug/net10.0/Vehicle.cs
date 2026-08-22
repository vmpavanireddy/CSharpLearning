using System;
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