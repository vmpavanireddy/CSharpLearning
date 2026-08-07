using System;
//Inheritance + Constructor
class Person_4
{
    public string Name { get; set; }

    public Person_4(string name)
    {
        Name = name;
    }
}

class Student_4 : Person_4
{
    public string Course { get; set; }

    public Student_4(string name, string course)
        : base(name)//This calls the parent class constructor.
    {
        Course = course;
    }
}
class Program_9
{
    static void Main()
    {
        Student_4 student = new Student_4("pavani", "C#");

        Console.WriteLine(student.Name);
        Console.WriteLine(student.Course);
    }
}