using System;
//inheritance with properties
class Person_3
{
    public string Name { get; set; }

    public int Age { get; set; }
}

class Student_2 : Person_3
{
    public string Course { get; set; }
}
class Program_8
{
    static void Main()
    {
        Student_2 student = new Student_2();

        student.Name = "pavani";
        student.Age = 21;
        student.Course = "C#";
    }
}