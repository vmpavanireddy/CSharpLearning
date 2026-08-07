using System;
//inheritance
class Animal_1//parent class//Base class//Super class
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog : Animal_1//child class //Derived class //Subclass inherits from Animal_1 parent class
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