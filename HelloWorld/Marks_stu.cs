using System;

class Stude
{
    private int marks;

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
            else
                Console.WriteLine("Invalid Marks");
        }
    }
}

class Marks_stu
{
    static void Main()
    {
        Stude s = new Stude();

        s.Marks = 95;
        Console.WriteLine(s.Marks);

        s.Marks = 120;
    }
}