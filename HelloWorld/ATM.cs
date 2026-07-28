using System;
public class ATM
{
    public void WithdrawMoney()
    {

        /*Requirement
        A customer wants to withdraw money from their account.
        Given
        Balance = £5,000
        Withdrawal Amount = £2,000
        Rules
        If the withdrawal amount is less than or equal to the balance
        Print "Withdrawal Successful"
        Display the remaining balance
        Otherwise
        Print "Insufficient Balance"
        Concepts to Practice
        Variables
        Comparison Operators
        if-else
        */
        float balance = 5000;
        int withdrawalAmount = 2000;
        if (withdrawalAmount <= balance)
        {
            Console.WriteLine("Withdrawal Successful");
            balance -= withdrawalAmount;
            Console.WriteLine($"Remaining Balance: £{balance}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
}