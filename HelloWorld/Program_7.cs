using System;
//what if about private members?
class Animal_2
{
    private int age;

    public string Name { get; set; }
}
class Dog_1 : Animal_2
{
    public void Test()
    {
        // age = 5; ❌//error //The Dog class cannot directly access Animal's private field.Even though Dog inherits from Animal.
    }
}
class Program_7
{
    static void Main()
    {
        Dog_1 dog = new Dog_1();
        dog.Name = "Buddy";
        // dog.age = 5; ❌//error //The Main method cannot directly access Animal's private field.
    }
}