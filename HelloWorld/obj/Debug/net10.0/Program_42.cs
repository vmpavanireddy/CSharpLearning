using System;
interface IAttackable
{
    void Attack();
}

class Player : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Enemy : Player
{
    public new void Attack()
    {
        Console.WriteLine("Enemy attacks");
    }
}
class Program_42
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        player.Attack(); // Output: Player attacks
        enemy.Attack();  // Output: Enemy attacks

        IAttackable attackablePlayer = player;
        IAttackable attackableEnemy = enemy;

        attackablePlayer.Attack(); // Output: Player attacks
        attackableEnemy.Attack();  // Output: Enemy attacks
    }
}