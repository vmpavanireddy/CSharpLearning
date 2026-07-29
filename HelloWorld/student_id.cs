using Microsoft.VisualBasic;
using System;
public class students
{
    public string Name;

    public int Age;

    public students(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age  : {Age}");
    }
}
public class student_id
{
    static void Main(Strings[] args)
    {
        students student = new students("pavani", 20);

        student.Display();
    }
}