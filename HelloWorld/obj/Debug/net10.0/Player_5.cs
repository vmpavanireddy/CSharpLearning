using System;

Player_5 player1 = new Player_5(100);
Player_5 player2 = new Player_5(200);

Console.WriteLine(player1.Health);
Console.WriteLine(player2.Health);

class Player_5
{
    public int Health { get; private set; }

    public Player_5(int health)
    {
        Health = health;
    }
}