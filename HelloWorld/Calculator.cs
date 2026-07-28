using System;
public class Calculator
{
    public void operations()
    {
        int num1 = 10;
        int num2 = 20;
        String operation = "+";
        switch(operation)
        {
            case "+":
            Console.WriteLine(num1 + num2);
            break;
            case "-":
            Console.WriteLine(num1 - num2);
            break;
            case "*":
            Console.WriteLine(num1 * num2);
            break;
            case "/":
            Console.WriteLine(num1 / num2);
            break;
        }
    }
}