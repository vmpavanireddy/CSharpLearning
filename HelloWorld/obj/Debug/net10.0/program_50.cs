using System;
class Character
{
    public void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Player : Character
{
    public new void Attack()
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
class program_50
{
    static void Main(string[] args)
    {
        Character character = new Character();
        Player player = new Player();
        Enemy enemy = new Enemy();

        character.Attack(); // Output: Character attacks
        player.Attack();    // Output: Player attacks
        enemy.Attack();     // Output: Enemy attacks

        Character charRefToPlayer = new Player();
        charRefToPlayer.Attack(); // Output: Character attacks

        Character charRefToEnemy = new Enemy();
        charRefToEnemy.Attack(); // Output: Character attacks
    }
}