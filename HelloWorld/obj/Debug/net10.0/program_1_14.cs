public class program_1_14
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum: " + sum);
        void myMethod()
        {
            Console.WriteLine("This is a method inside Main.");
        }
        myMethod();
    }
}