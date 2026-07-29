using System;
public class student
{
    public Student()
    {
        Console.WriteLine("Student object created.");
    }
}
public class clg
{
    static void Main(String[] args)
    {
        //A constructor is a special method that runs automatically when an object is created.
        //There is no return type.Not even void.
        student regno=new student();
        //We never wrote:student.Student();The constructor runs automatically.
        
        
    }
}