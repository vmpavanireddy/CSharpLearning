using System;
//polymorphism
//The same method call can behave differently depending on the object.
/*
Imagine you tell:

"Make a sound!"

Different animals respond differently:

Dog → Woof!
Cat → Meow!
Cow → Moo!

The command is the same:

MakeSound()

But the behavior is different.

That's polymorphism.
*/
class Animal
{
    //what if we want Dog to make its own sound?
//That's where polymorphism starts.
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

}
//virtual:A child class is allowed to provide its own implementation of this method.
//over ride:I'm replacing the parent's implementation with my own implementation.
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
//So far, this is method overriding.
class program_12
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.MakeSound();
        Cat cat = new Cat();
        cat.MakeSound();
        Cow cow = new Cow();
        cow.MakeSound();
    }
}