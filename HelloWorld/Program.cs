Console.WriteLine("Hello, pavani!");
//variable syntax
//datatype variableName = value;
string Name = "divya";
Console.WriteLine("yo, " + Name + "!");
//string -data type
//name-variableName 
//= - assignment operator (stores the value)
//value - value assigned to the variable
//;-semicolon (end of statement)

//changing the value of a variable
Name = "deepthi";
Console.WriteLine("hlo, " + Name + "!");
//The second time we didn't write string again.
//This is because the variable was already created.
//We can change the value of a variable as many times as we want.
string Name1 = "pavani";
Console.WriteLine("hii, " + Name1 + "!");
int age = 20;
Console.WriteLine("age is: " + age);
bool loggedIn = true;
Console.WriteLine("loggedIn: " + loggedIn);
double salary = 200000.5;
Console.WriteLine("salary is: " + salary);

string Name2 = "divya";
age = 19;
loggedIn = false;
salary = 250000.0;
//output with using string interpolation
Console.WriteLine($"Hello, {Name2}!");
Console.WriteLine($"age is: {age}");
Console.WriteLine($"loggedIn: {loggedIn}");
Console.WriteLine($"salary is: {salary}");

//variable naming rules
//1. variable name can contain letters, digits, and underscores.
//2. variable name must begin with a letter or an underscore.   
//3. variable name cannot begin with a digit.
//4. variable name cannot contain spaces or special characters.
//5. variable name cannot be a reserved keyword.ex: int, string, class, public, private, etc.
//6. variable name is case sensitive. ex: Name and name are different variables.
//7. variable name should be meaningful and descriptive. ex: age, salary, loggedIn, etc.

//Using descriptive names:
string firstName = "divya";
string lastName = "reddy";
Console.WriteLine($"Hello, {firstName} {lastName}!");
int userAge = 20;
Console.WriteLine($"userAge is: {userAge}");
bool isaprogrammer = true;
Console.WriteLine($"isaprogrammer: {isaprogrammer}");
double userSalary = 200000.5;
Console.WriteLine($"userSalary is: {userSalary}");