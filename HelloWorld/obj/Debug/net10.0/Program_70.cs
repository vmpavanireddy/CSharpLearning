using System;

delegate void GameAction();

class Program_70
{
    static void Attack()
    {
        Console.WriteLine("Attack");
    }

    static void Main()
    {
        GameAction action = Attack;

        action();
    }
}