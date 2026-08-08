using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says Meow!");
    }
}

class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cow says Moo!");
    }
}
/*
Animal animal = new Dog();
The left side says:

Animal

The right side says:

Dog

But this is completely valid because:

Dog IS-A Animal

because of inheritance.
*/
class Program_13
{
    static void Main()
    {
        Animal animal = new Dog();

        animal.MakeSound();
        /*
        You might expect:Animal makes a sound
        But the output is:Dog says Woof!
        Because the actual object is a Dog.
        This is the heart of runtime polymorphism.
*/
//C# uses the actual object's overridden method.
    }
}