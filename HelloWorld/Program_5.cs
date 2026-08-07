using System;
//inheritance
class Animal_1
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog : Animal_1
{
}
//: is what we use to specify inheritance.
class Program_5
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Name = "Tommy";

        Console.WriteLine(dog.Name);

        dog.Eat();
    }
}