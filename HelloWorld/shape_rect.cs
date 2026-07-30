//Expression-Bodied Property
using System;

class Rectang
{
    public int Length { get; set; }
    public int Width { get; set; }

    public int Area => Length * Width;
}

class shape_rect
{
    static void Main()
    {
        Rectang r = new Rectang();

        r.Length = 10;
        r.Width = 5;

        Console.WriteLine("Area = " + r.Area);
    }
}