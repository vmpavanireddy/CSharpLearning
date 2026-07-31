//Access Modifiers
using System;

class person
{
    //A constructor can also be private.

    /*private person()
    {
    }
    *///example
    //internal means:"Any class inside this project can use it, but code from another project cannot."
    //A public member can be accessed from anywhere.
    public string Name { get; set; }
    //A private member is accessible only inside the same class.
    private int age = 25;

    public void DisplayAge()
    {
        Console.WriteLine(age);
    }
    private double balance;

    public double Balance
    {
        get
        {
            return balance;
        }

        private set
        {
            balance = value;
        }
    }
    //Private Methods
    public int Square(int number)
    {
        return Multiply(number, number);
    }

    private int Multiply(int a, int b)
    {
        return a * b;
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

        //student.Balance = 5000; error

        Console.WriteLine(student.Balance);

        Console.WriteLine(student.Square(5));

        // calculator.Multiply(2, 3);  Error cause private
    }
}