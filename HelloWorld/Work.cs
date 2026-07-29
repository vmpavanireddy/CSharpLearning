using System;
public class Emplyees
{
        public string task;

//Methods Inside a Class
public void todo()
    {
        Console.WriteLine($"{task} is in progress.");
    }   
}
public class Work
{
    static void Main(String[] args)
    {
        Emplyees emp1=new Emplyees();
        emp1.task="research";
        emp1.todo();
        
    }
}