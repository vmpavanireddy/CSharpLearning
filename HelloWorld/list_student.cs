//Access Modifiers
using System;

class person
{
    //A public member can be accessed from anywhere.
    public string Name { get; set; }
    //A private member is accessible only inside the same class.
    private int age = 25;

    public void DisplayAge()
    {
        Console.WriteLine(age);
    }
}

class list_student
{
    static void Main()
    {
        person student = new person();

        student.Name = "pavani";

        Console.WriteLine(student.Name);
        
        student.DisplayAge();

        // Console.WriteLine(student.age);  error
    }
}