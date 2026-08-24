using System;

interface IAttackable
{
    void Attack();
}

class Character
{
    public string Name = "Hero";
}

class Player : Character, IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_69
{
    static void Main()
    {
        Player player = new Player();

        Character character = player;
        IAttackable attacker = player;

        Console.WriteLine(player.Name);
        Console.WriteLine(character.Name);

        attacker.Attack();
    }
}