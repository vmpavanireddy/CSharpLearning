using System;
class BankAccount
{
    //syntax for properties
    /*.  private string name;

public string Name
{
    get
    {
        return name;
    }

    set
    {
        name = value;
    }
}
*/
//the next code is shortcut -The compiler secretly creates the private field for you.
//1st way
//Use this when you don't need validation.
    public int account_no { get; set; }
    //reading value=get
    //storing-assigning=set

    //2nd way
    //Property with Validation (Backing Field)
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value >= 0)
            {
                //age should never be negative.
                age = value;
            }
        }
    }

}
class account
{
    static void Main(String[] args)
    {
        //we use property for validation 
        BankAccount account_1=new BankAccount();
        account_1.account_no=29863;
        Console.WriteLine($" account_no:{account_1.account_no}");
        account_1.Age=20;
        Console.WriteLine($" age:{account_1.Age}");

    }
}