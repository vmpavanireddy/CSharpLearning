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

    }
}