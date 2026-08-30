using System;

delegate void GameAction();

class Program_1_10
{
    static void Attack()
    {
        Console.WriteLine("Attack");
    }

    static void Heal()
    {
        Console.WriteLine("Heal");
    }

    static void PerformAction(GameAction action)
    {
        action();
    }

    static void Main()
    {
        PerformAction(Attack);
        PerformAction(Heal);
    }
}