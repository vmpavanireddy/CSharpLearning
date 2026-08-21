using System;

Player_6 player = new Player_6("Alex");

Console.WriteLine(player.Name);

class Player_6
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
    }

    public Player_6(string name)
    {
        this.name = name;
    }
}