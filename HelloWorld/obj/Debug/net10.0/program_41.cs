using System;
class Player
{
    public string Name { get; set; }
    public int Level { get; private set; } = 1;
    public int XP { get; private set; }

    public void GainXP(int amount)
    {
        XP += amount;

        if (XP >= 100)
        {
            Level++;
            XP = 0;

            Console.WriteLine("Level Up!");
        }
    }
}
class program_41
{
    static void Main(string[] args)
    {
        Player player = new Player();

        player.Name = "Hero";

        player.GainXP(60);
        player.GainXP(40);

        Console.WriteLine(player.Level); // 2

        player.GainXP(50);
        Console.WriteLine($"Player Level: {player.Level}, XP: {player.XP}"); // Level: 1, XP: 50

        player.GainXP(60);
        Console.WriteLine($"Player Level: {player.Level}, XP: {player.XP}"); // Level: 2, XP: 0
    }
}