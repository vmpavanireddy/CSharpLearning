using System;

class Circle_1
{
    public double Radius { get; set; }

    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }
}

class shap
{
    static void Main()
    {
        Circle_1 c = new Circle_1();
        c.Radius = 5;

        Console.WriteLine(c.Area);  
    }
}