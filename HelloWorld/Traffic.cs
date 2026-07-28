using System;
public class Traffic
{
    public void signal()
    {
        String signal = "red";

        switch (signal)
        {
            case "red":
                Console.WriteLine("stop");
                break;
            case "yellow":
                Console.WriteLine("ready");
                break;
            case "green":
                Console.WriteLine("go");
                break;
        }
    }
}
