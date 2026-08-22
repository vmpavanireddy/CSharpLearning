using System;
class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}
class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks with a sword");
    }
}
class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks with claws");
    }
}