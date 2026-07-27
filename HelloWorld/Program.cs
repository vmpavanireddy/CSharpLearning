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
//if (condition)
//{
    // Code runs if the condition is true
//}
//else
//{
    // Code runs if the condition is false
//}
int userAge2 = 20;
if (userAge2 >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}
int age_nam = 15;

if (age_nam >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
 int marks = 82;

if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 75)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}
//nested if-else statements
bool hasTicket = true;
int myage = 20;

if (hasTicket)
{
    if (myage >= 18)
    {
        Console.WriteLine("Enjoy the movie!");
    }
}
//Logical Operators with if
int my_age = 25;
bool hasLicense = true;

if (my_age >= 18 && hasLicense)
{
    Console.WriteLine("You can drive.");
}
bool weekend = true;
bool holiday = false;

if (weekend || holiday)
{
    Console.WriteLine("No office today!");
}
bool isLogged_In = false;

if (!isLogged_In)
{
    Console.WriteLine("Please login.");
}
//switch statement
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;  
        case 6:
        Console.WriteLine("Saturday");
        break;
        case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid Day");
        break;
}
//real world example Imagine you're building a login system.
string username = "jyothi";
string password = "1234";

if (username == "jyothi" && password == "1234")
{
    Console.WriteLine("Login Successful");
}
else
{
    Console.WriteLine("Invalid Credentials");
}
//example
double orderAmount = 120;

if (orderAmount >= 100)
{
    Console.WriteLine("Free Shipping!");
}
else
{
    Console.WriteLine("Shipping Charge: $10");
}
//even or odd number
int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is an even number.");
}
else
{
    Console.WriteLine($"{number} is an odd number.");
}
//even or odd number using switch statement
int num = 8;
switch (num % 2)
{
    case 0:
        Console.WriteLine($"{num} is an even number.");
        break;
    case 1:
        Console.WriteLine($"{num} is an odd number.");
        break;
    default:
        Console.WriteLine("Invalid number.");
        break;
}
//example largest number
int num1 = 10;
int num2 = 20;
if (num1 > num2)
{
    Console.WriteLine($"{num1} is the largest number.");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num2} is the largest number.");
}
else
{
    Console.WriteLine("Both numbers are equal.");
}
//for more than 2 numbers
int num3 = 15;
if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine($"{num1} is the largest number.");
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine($"{num2} is the largest number.");
}
else
{
    Console.WriteLine($"{num3} is the largest number.");
}
//login check with switch statement
string userRole = "admin";
switch (userRole)
{
    case "admin":
        Console.WriteLine("Welcome, Admin!");
        break;
    case "editor":
        Console.WriteLine("Welcome, Editor!");
        break;
    case "viewer":
        Console.WriteLine("Welcome, Viewer!");
        break;
    default:
        Console.WriteLine("Invalid Role");
        break;
}
//grade caclulation using switch statement
int marks1 = 85;
switch (marks1 / 10)
//calculation is done to get the first digit of the marks. For example, if marks is 85, then 85/10 = 8.5, which is converted to 8.
{
    case 10:
    Console.WriteLine("Grade A+");
        break;
    case 9:
        Console.WriteLine("Grade A");
        break;
    case 8:
        Console.WriteLine("Grade B");
        break;
    case 7:
        Console.WriteLine("Grade C");
        break;
    case 6:
        Console.WriteLine("Grade D");
        break;  
    case 5:
        Console.WriteLine("Grade E");
        break;
    default:
        Console.WriteLine("Fail");
        break;
}
//loops
//for loop 
// for (initialization; condition; update){
    // code to be executed
//}
for (int i1 = 1; i1 <= 5; i1++)
{
    Console.WriteLine($"Iteration {i1}");
}
//Printing Text
for (int i2 = 1; i2 <= 3; i2++)
{
    Console.WriteLine("Welcome");
}
//Counting Backwards
for (int i3 = 5; i3 >= 1; i3--)
{
    Console.WriteLine($"Countdown: {i3}");
}
//Skipping Numbers Print even numbers from 2 to 10:
for (int i4 = 2; i4 <= 10; i4 += 2)
{
    Console.WriteLine(i4);
}
//Using Variables Inside a Loop
string name = "pavani";

for (int i5 = 1; i5 <= 3; i5++)
{
    Console.WriteLine($"welcome {name}");
}
//Multiplication Table
int number1 = 6;
for (int i6 = 1; i6 <= 10; i6++)
{
    Console.WriteLine($"{number1} x {i6} = {number1 * i6}");
}
//while Loop A while loop repeats as long as a condition is true.
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
//must update i yourself. If you forget i++, the loop will never end.
//example: Print numbers from 1 to 5 using while loop
int j = 1;
while (j <= 5)
{
    Console.WriteLine(j);
    j++;
}
//example: Print even numbers from 2 to 10 using while loop
int k = 2;
while (k <= 10)
{
    Console.WriteLine(k);
    k += 2;
}
//example: Print odd numbers from 1 to 9 using while loop
int l = 1;
while (l <= 9)
{
    Console.WriteLine(l);
    l += 2;
}
//example: Print multiplication table of 5 using while loop
int m = 1;
int number2 = 5;
while (m <= 10)
{
    Console.WriteLine($"{number2} x {m} = {number2 * m}");
    m++;
}   
//do...while Loop ,A do...while loop always runs at least once.
int q = 6;

do
{
    Console.WriteLine(q);
    q++;
}
while (q <= 5);
//example: Print numbers from 1 to 5 using do...while loop
int n = 1;
do
{
    Console.WriteLine(n);
    n++;
}
while (n <= 5);
//example: Print even numbers from 2 to 10 using do...while loop    
int o = 2;
do
{
    Console.WriteLine(o);
    o += 2;
}
while (o <= 10);
//example: Print odd numbers from 1 to 9 using do...while loop
int p = 1;
do
{
    Console.WriteLine(p);
    p += 2;
}
while (p <= 9); 
//foreach Loop ,foreach is used with collections (arrays, lists, etc.).
string[] fruits = { "Apple", "Banana", "Orange" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
//example: Print all elements of an array using foreach loop
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number3 in numbers)
{
    Console.WriteLine(number3);
}
//example: Print all characters of a string using foreach loop
string word = "Hello";
foreach (char letter in word)
{
    Console.WriteLine(letter);
}
//Real-World Example ,Imagine you're displaying the first 5 products on an online store:
for (int productNumber = 1; productNumber <= 5; productNumber++)
{
    Console.WriteLine($"Displaying Product #{productNumber}");
}
//using discriptive names
for (int productIndex = 1; productIndex <= 5; productIndex++)
{
    Console.WriteLine($"Displaying Product #{productIndex}");
}
//example: Print the first 5 even numbers using a for loop
for (int evenNumber = 2; evenNumber <= 10; evenNumber += 2)
{
    Console.WriteLine(evenNumber);
}
//pattern printing using for loop
for (int row = 1; row <= 5; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
//example: Print a square pattern of size 4 using a for loop
int size = 4;
for (int row = 1; row <= size; row++)
{
    for (int col = 1; col <= size; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
//example: Print a right triangle pattern of size 5 using a for loop
int triangleSize = 5;
for (int row = 1; row <= triangleSize; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("*"); 
    }
    Console.WriteLine();
}
//arrays
//An array stores multiple values of the same data type in a single variable.
//syntax
//datatype[] arrayName = new datatype[size];
//dataType[] arrayName = { values };
int[] numbers_10s = { 10, 20, 30, 40, 50 };
//first value
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);
Console.WriteLine(numbers[3]);
Console.WriteLine(numbers[4]);
//Arrays always start from 0.
//String Array,Arrays can store strings too.
string[] vegies =
{
    "Carrot",
    "Potato",
    "Tomato"
};

Console.WriteLine(vegies[0]);
Console.WriteLine(vegies[1]);
Console.WriteLine(vegies[2]);
//boolean Array,Arrays can store boolean values too.
bool[] answers =
{
    true,
    false,
    true
};

Console.WriteLine(answers[0]);
//Changing an Array Value,Arrays are mutable.
string[] fruits_abc =
{
    "Apple",
    "Banana",
    "Orange"
};

fruits_abc[1] = "Mango";

Console.WriteLine(fruits_abc[1]);
//Length Property,Use .Length to get the number of elements in an array.
int[] numbers_123 = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Length of numbers array: {numbers_123.Length}");
//Loop Through an Array
for (int i_no = 0; i_no < numbers_123.Length; i_no++)
{
    Console.WriteLine(numbers_123[i_no]);
}
//Using foreach
foreach (int number_123 in numbers_123)
{
    Console.WriteLine(number_123);
}
//means,"Take one number at a time from the array."You don't need indexes here.
