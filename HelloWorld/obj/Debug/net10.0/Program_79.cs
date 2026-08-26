using System;

class Player
{
    private int health;

    public string Name { get; set; }

    public int Health
    {
        get
        {
            return health;
        }
        private set
        {
            health = value;
        }
    }

    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}

class Program_79
{
    static void Main()
    {
        Player player = new Player("Hero", 100);

        Console.WriteLine(player.Name);
        Console.WriteLine(player.Health);

        player.TakeDamage(30);

        Console.WriteLine(player.Health);
    }
}