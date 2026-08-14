using System;
class Player
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }
}
class Program_34
{
    static void Main(string[] args)
    {
        
    }
}