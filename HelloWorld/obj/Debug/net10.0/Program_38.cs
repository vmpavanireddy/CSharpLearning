using System;
class Phone
{
    public int Battery { get; private set; } = 100;

    public void Use(int percentage)
    {
        Battery -= percentage;

        if (Battery < 0)
            Battery = 0;
    }

    public void Charge()
    {
        Battery = 100;
    }
}
class Program_38
{
    static void Main(string[] args)
    {
        Phone phone = new Phone();

        phone.Use(30);

        Console.WriteLine(phone.Battery); // 70

        phone.Charge();

        Console.WriteLine(phone.Battery); // 100
    }
}