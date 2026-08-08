//virtual vs override
/*Parent
public virtual void method()
Means:
"Child classes are allowed to change this."
Child
public override void method()
Means:
"I'm changing the parent's behavior."
base
Child calls parent's implementation.
Suppose the parent does something useful 
the child wants to keep the parent's behavior and then add its own.
*/
using System;

class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player uses sword!");
    }
}

class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks with claws!");
    }
}

class Program_15
{
    static void Main()
    {
        // Create an array of Character objects
        Character[] characters =
 {
    new Player(),
    new Enemy(),
    new Player(),
    new Enemy()
};
        foreach (Character character in characters)
        {
            character.Attack();
        }
    }
}

