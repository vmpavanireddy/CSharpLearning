using System;

delegate void GameAction();

class Program_71
{
    static void Attack()
    {
        Console.WriteLine("Attack");
    }

    static void PlaySound()
    {
        Console.WriteLine("Sound");
    }

    static void Main()
    {
        GameAction action = Attack;

        action += PlaySound;

        action();
    }
}