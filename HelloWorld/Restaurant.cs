using System;
public class Restaurant
{
    public void Bill()
    {
        float bruger=12;
        float drink=3;
        float fries=5;
        float vetrate=0.10f;
        float subtotal=bruger+drink+fries;
        float Vat_amt=subtotal*vetrate;
        float grandtotal=subtotal+Vat_amt;
        Console.WriteLine("subtotal is"+ subtotal);
        Console.WriteLine("vat anount"+Vat_amt);
        Console.WriteLine("grand total is"+grandtotal);

    }
}