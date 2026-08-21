using System;

Player_1 player = new Player_1();
Console.WriteLine(player.Health); 

class Player_1
{
    public int Health { get; private set; }

    public Player_1()
    {
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
