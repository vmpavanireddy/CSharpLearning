using System;
class Book
{
    public string Title { get; set; }
    public bool IsAvailable { get; set; } = true;

    public void Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine("Book borrowed");
        }
        else
        {
            Console.WriteLine("Not available");
        }
    }

    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine("Book returned");
    }
}
class Program_35
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Title = "C# Programming";

        Console.WriteLine($"Title: {book.Title}, Available: {book.IsAvailable}");
        book.Borrow();
        Console.WriteLine($"Available after borrowing: {book.IsAvailable}");
        book.Return();
        Console.WriteLine($"Available after returning: {book.IsAvailable}");
    }
}