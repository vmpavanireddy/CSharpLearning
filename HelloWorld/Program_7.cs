using System;
//what if about private members?
class Animal_2
{
    private int age;

    public string Name { get; set; }
    //if we use protected
     protected int age_animal;
}
class Dog_1 : Animal_2
{
    public void Test()
    {
        // age = 5; ❌//error //The Dog class cannot directly access Animal's private field.Even though Dog inherits from Animal.
        age_animal = 5; // ✅//This is allowed because age_animal is protected and Dog inherits from Animal.
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