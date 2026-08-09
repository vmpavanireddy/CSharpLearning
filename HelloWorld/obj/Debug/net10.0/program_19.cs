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
        Character player = new Player
        {
            Name = "Knight"
        };

        Character enemy = new Enemy
        {
            Name = "Goblin"
        };

        Character npc = new NPC
        {
            Name = "Villager"
        };

        player.Attack();
        enemy.Attack();
        npc.Attack();
    }
}