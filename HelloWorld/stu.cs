using System;

class Studente
{
    public string Name { get; set; }
    public int Age { get; set; }
}
//Auto Property (Most Common),Use this when you don't need validation.
class stu
{
    static void Main(string[] args)
    {
        Studente student = new Studente();

        student.Name = "pavani";
        student.Age = 20;

        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
    }
}