using System;
public class College
{
    public void Admission()
    {
        int marks = 85;
        int age= 18;
        bool entrance_exam_passed = true;
        if(marks >=75 && age >= 17 && entrance_exam_passed)
        {
            Console.WriteLine("Admission Granted");
        }
        else
        {
            Console.WriteLine("Admission Rejected");
        }
    }
}