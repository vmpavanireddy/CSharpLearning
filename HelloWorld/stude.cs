//Property with Validation (Backing Field)
using System;

class Studens
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
}

class stude
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.Age = 25;
        Console.WriteLine(student.Age);

        student.Age = -10;
        Console.WriteLine(student.Age);
    }
}