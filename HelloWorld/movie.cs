/*
Requirement
A person wants to enter a movie theatre.
Given
Ticket Available = true
Age = 19
Rules
If:
Ticket is available
AND age is 18 or above
Display:
Enjoy the Movie!

Otherwise display:
Entry Denied

Concepts
Boolean Variables
Logical AND (&&)
if
*/
bool ticketAvailable = true;
int age = 19;
if(ticketAvailable && age >= 18)
{
    Console.WriteLine("Enjoy the Movie!");
}
else
{
    Console.WriteLine("Entry Denied");
}