using System;
//class
public class Students
{
    public string Name;

    public int Age;
}
public class class_student
{
    static void Main(String[] args)
    {
        Students student1 = new Students();

        Console.WriteLine("Student object created.");

        student1.Name = "pavani";

        student1.Age = 20;
        Console.WriteLine(student1.Name);

        Console.WriteLine(student1.Age);
        //multiple objects
        Students student2 = new Students();
        student1.Name = "divya";

        student1.Age = 19;
        Console.WriteLine(student2.Name);

        Console.WriteLine(student2.Age);

    }
}