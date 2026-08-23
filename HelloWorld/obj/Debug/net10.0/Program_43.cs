using System;
interface IAttackable
{
    void Attack();
}

class Character : IAttackable
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
        Console.WriteLine("Player attacks");
    }
}

class Enemy : Player
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks");
    }
}
class Program_43
{
    static void Main(string[] args)
    {
        Character character = new Character();
        character.Attack();

        Player player = new Player();
        player.Attack();

        Enemy enemy = new Enemy();
        enemy.Attack();
    }
}