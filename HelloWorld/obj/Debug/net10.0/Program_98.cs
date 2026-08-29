using System;

delegate void GameAction();

class Program_98
{
    static void Attack()
    {
        Console.WriteLine("Attack");
    }

    static void Heal()
    {
        Console.WriteLine("Heal");
    }

    static void PlaySound()
    {
        Console.WriteLine("Sound plays");
    }

    static void Main()
    {
        GameAction action = Attack;

        action();

        action += Heal;
        action += PlaySound;

        action();
    }
}