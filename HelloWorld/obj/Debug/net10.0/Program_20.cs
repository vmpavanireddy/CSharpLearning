//Interfaces in C#
using System;
//An interface defines a contract — it tells a class what it must be able to do, without deciding how it does it.
//syntax of interface
/*
interface interface_name
{
    //methods
    //properties
    //events
    //indexers
}
*/
interface IPayment
//I is a convention used to indicate an interface.naming convention:I + Name
{
    void MakePayment();
}
class Program_20
{
    static void Main(string[] args)
    {

    }
}