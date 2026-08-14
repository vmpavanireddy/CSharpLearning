using System;
class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }

    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 75) return "B";
        else if (Marks >= 50) return "C";
        else return "Fail";
    }
}

class Program_33
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "pavani ";
        student.Marks = 85;

        Console.WriteLine($"Student: {student.Name}, Marks: {student.Marks}, Grade: {student.GetGrade()}");
    }
}