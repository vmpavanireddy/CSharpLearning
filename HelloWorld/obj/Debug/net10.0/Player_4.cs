using System;

Player_4 player1 = new Player_4();
Player_4 player2 = new Player_4();

player1.TakeDamage(20);
player2.TakeDamage(50);

Console.WriteLine(player1.Health);
Console.WriteLine(player2.Health);

class Player_4
{
    public int Health { get; private set; }

    public Player_4()
    {
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
        }
    }
}