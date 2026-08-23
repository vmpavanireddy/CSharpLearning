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
class Program_51
{
    static void Main(string[] args)
    {
        Character character = new Character();
        character.Attack(); // Output: Character attacks

        Player player = new Player();
        player.Attack(); // Output: Player attacks

        Enemy enemy = new Enemy();
        enemy.Attack(); // Output: Enemy attacks

        // Demonstrating polymorphism
        Character polyCharacter = new Player();
        polyCharacter.Attack(); // Output: Player attacks

        polyCharacter = new Enemy();
        polyCharacter.Attack(); // Output: Enemy attacks
    }
}