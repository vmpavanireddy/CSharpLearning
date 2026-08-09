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
class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks with claws");
    }
}
class NPC : Character
{
    public override void Attack()
    {
        Console.WriteLine("NPC cannot attack");
    }
}
class program_19
{
    static void Main(string[] args)
    {

    }
}