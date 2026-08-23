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
class Program_53
{
    static void Main(string[] args)
    {
        Character character = new Character();
        character.Attack(); // Output: Character attacks

        Player player = new Player();
        player.Attack(); // Output: Player attacks

        Character characterAsPlayer = new Player();
        characterAsPlayer.Attack(); // Output: Player attacks
    }
}