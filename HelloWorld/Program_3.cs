using System;
class Student_1
{
    private int marks;

    public int Marks
    {
        get
        {
            return marks;
        }
    }

    public void SetMarks(int value)
    {
        if (value >= 0 && value <= 100)
        {
            marks = value;
        }
    }
}
class Program_3
{
    static void Main(string[] args)
    {
        Student_1 student = new Student_1();

        student.SetMarks(95);

        Console.WriteLine(student.Marks);

        student.SetMarks(150);

        Console.WriteLine(student.Marks);
    }
}