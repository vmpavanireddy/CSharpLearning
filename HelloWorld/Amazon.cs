using System;
public class Amazon
{
    public void checkout()
    {
        bool isLoggedIn = true;
        int cart_items = 5;
        int amt = 150;
        bool isPremiumMember = true;
        int delivery = 0;
        if (isLoggedIn)
        {
            if (cart_items > 0)
            {
                if (isPremiumMember && amt > 100)
                {
                    Console.WriteLine("You are eligible for free delivery");
                }
                else
                {
                    delivery = 20;

                }
            }
        }
        int totalAmount = amt + delivery;
        Console.WriteLine("Total amount to be paid is: " + totalAmount);
    }
}
