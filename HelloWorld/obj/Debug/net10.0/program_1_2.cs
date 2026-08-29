
class Player
{
    private HealthComponent health;

    public Player()
    {
        health = new HealthComponent();
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }
}
class program_1_2
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.TakeDamage(10);
    }
}