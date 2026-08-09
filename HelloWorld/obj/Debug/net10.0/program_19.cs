//example
using System;
abstract class Character
{
    public string Name { get; set; }

    public abstract void Attack();
}
class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks with sword");
    }
}
class program_19
{
    static void Main(string[] args)
    {

    }
}