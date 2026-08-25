class HealthComponent
{
    public int Health = 100;

    public void TakeDamage(int damage)
    {
        Health -= damage;

        Console.WriteLine("Health: " + Health);
    }
}

class MovementComponent
{
    public void Move()
    {
        Console.WriteLine("Moving");
    }
}

class WeaponComponent
{
    public void Attack()
    {
        Console.WriteLine("Attacking");
    }
}
class Player
{
    public HealthComponent Health;
    public MovementComponent Movement;
    public WeaponComponent Weapon;

    public Player()
    {
        Health = new HealthComponent();
        Movement = new MovementComponent();
        Weapon = new WeaponComponent();
    }
}
class Program_77
{
    static void Main(string[] args)
    {
        Player player = new Player();

        player.Movement.Move();
        player.Weapon.Attack();
        player.Health.TakeDamage(20);
    }
}