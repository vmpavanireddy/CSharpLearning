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

//variables store data,operators let us work with that data
//types of operators
//1. arithmetic operators
//2. comparison operators
//3. logical operators
//4. assignment operators

int a = 10;
int b = 5;
int sum = a + b;
int difference = a - b;
int product = a * b;
int quotient = a / b;
int remainder = a % b;
//arithmetic operators
Console.WriteLine($"a + b = {sum}");
Console.WriteLine($"a - b = {difference}");
Console.WriteLine($"a * b = {product}");
Console.WriteLine($"a / b = {quotient}");
Console.WriteLine($"a % b = {remainder}");
//comparison operators
bool isEqual = a == b;
bool isNotEqual = a != b;
Console.WriteLine($"a == b: {isEqual}");
Console.WriteLine($"a != b: {isNotEqual}");
Console.WriteLine( 15 >= 10); //true
Console.WriteLine( 15 <= 10); //false

//assignment operators
int c = 10;
c += 5; // c = c + 5
Console.WriteLine($"c += 5: {c}");
c -= 3; // c = c - 3
Console.WriteLine($"c -= 3: {c}");
c *= 2; // c = c * 2
Console.WriteLine($"c *= 2: {c}");
c /= 2; // c = c / 2
Console.WriteLine($"c /= 2: {c}");

//logical operators
//logical operators are used to combine conditional statements
//&& - logical AND operator-Both conditions must be true
//|| - logical OR operator-At least one condition must be true
//! - logical NOT operator
bool isTrue = true;
bool isFalse = false;
Console.WriteLine($"isTrue && isFalse: {isTrue && isFalse}");
Console.WriteLine($"isTrue || isFalse: {isTrue || isFalse}");
Console.WriteLine($"!isTrue: {!isTrue}");

//now using realworld example for each operator
//Imagine you're writing a shopping application.
//using descriptive names
//example of assignment operators
int itemPrice = 100;
itemPrice += 20; // itemPrice = itemPrice + 20
Console.WriteLine($"itemPrice: ${itemPrice}");
//example of comparison operators
int userAge1 = 20;
int minAge1 = 18;
bool isEligible1 = userAge1 >= minAge1;
Console.WriteLine($"isEligible: {isEligible1}");
//example of logical operators
bool isLoggedIn = true;
bool hasItemsInCart = true;
bool canCheckout = isLoggedIn && hasItemsInCart;
Console.WriteLine($"canCheckout: {canCheckout}");
bool isLoggedIn_1 = false;
bool hasItemsInCart_1 = true;
bool canCheckout1 = isLoggedIn_1 || hasItemsInCart_1;
Console.WriteLine($"canCheckout1: {canCheckout1}");
//not operator
bool isLoggedIn_2 = false;
bool isNotLoggedIn = !isLoggedIn_2;
Console.WriteLine($"isNotLoggedIn: {isNotLoggedIn}");
int price = 100;
int discount = 20;
int quantity = 2;
double total = price * quantity;
int finalPrice = price - discount;
Console.WriteLine($"finalPrice: ${finalPrice}");
Console.WriteLine($"total: ${total}");