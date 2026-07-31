using System;

public class Player_S
{
    public string Name { get; set; }

    public int Health { get; private set; }  

    public Player_S(string name)
    {
        Name = name;
        Health = 100;  
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
        {
            Health += amount;
            if (Health > 100)
                Health = 100;
        }
    }
}

class gamein
{
    static void Main()
    {
        Player_S p = new Player_S("Hero");

        p.TakeDamage(30);
        p.Heal(20);
        p.TakeDamage(200);  

        Console.WriteLine(p.Name);
        Console.WriteLine(p.Health);
    }
}