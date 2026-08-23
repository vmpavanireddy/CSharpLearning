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
class Program_52
{
    static void Main(string[] args)
    {
        Character character = new Character();
        character.Attack(); // Output: Character attacks

        Player player = new Player();
        player.Attack(); // Output: Player attacks

        Character characterAsPlayer = new Player();
        characterAsPlayer.Attack(); // Output: Character attacks
    }
}