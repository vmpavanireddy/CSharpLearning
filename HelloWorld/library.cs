using System;
class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{Title} - {Author}");
    }
}
class library
{
    static void Main(string[] args)
    {
        Book note = new Book("hello world", "pavani");

        note.Display();
    }
}