using System;

delegate void DeathAction();

class Program_73
{
    static void GiveXP()
    {
        Console.WriteLine("Player gets XP");
    }

    static void PlayDeathSound()
    {
        Console.WriteLine("Death sound plays");
    }

    static void UpdateUI()
    {
        Console.WriteLine("UI updated");
    }

    static void Main()
    {
        DeathAction action = GiveXP;

        action += PlayDeathSound;
        action += UpdateUI;

        action();
    }
}