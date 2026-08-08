using System;
class Character
{
    public string Name { get; set; }

    public int Health { get; set; }

    public void Move()
    {
        Console.WriteLine("Character is moving");
    }
}
class Player : Character
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}
class Enemy : Character
{
    public void Attack()
    {
        Console.WriteLine("Enemy attacks");
    }
}
class Program_11
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.Name = "Hero";
        player.Health = 100;
        player.Move();
        player.Attack();

        Enemy enemy = new Enemy();
        enemy.Name = "Villain";
        enemy.Health = 80;
        enemy.Move();
        enemy.Attack();
    }
}