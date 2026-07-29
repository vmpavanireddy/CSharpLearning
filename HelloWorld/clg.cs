using System;
public class student
{
    public student()
    {
        Console.WriteLine("Student object created.");
    }
}
class Students_no
{
    public string Name;
    public int Age;

    public Students_no(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
public class clg
{
    static void Main(String[] args)
    {
        //A constructor is a special method that runs automatically when an object is created.
        //There is no return type.Not even void.
        student regno = new student();
        //We never wrote:student.Student();The constructor runs automatically.
        Students_no stu_no = new Students_no("deepthi", 18);
        Console.WriteLine(stu_no.Name);
        Console.WriteLine(stu_no.Age);

    }
}