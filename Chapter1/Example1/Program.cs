// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Declar Variable foat and Double
float floatPI = 3.1415926535893238f;
double doublePI = 3.1415926535899323;
Console.WriteLine(floatPI);
Console.WriteLine(doublePI);
decimal decimalPI = 3.141592358979323846m;
Console.WriteLine(decimalPI);

//Boolen Variable Decalaration
int a = 4;
int b = 5;
bool greaterAB = a > b;
bool equalA = (a == 4);
if(greaterAB)
{
    Console.WriteLine(greaterAB + "(a > b");
}
else
{
    Console.WriteLine(greaterAB + " b <= a");
}
Console.WriteLine("greater = " + greaterAB);
Console.WriteLine("equalA1 = " + equalA);

// Character char declaration
char ch = 'a';
Console.WriteLine("the code of " + ch + (int)ch);
ch = 'b';
Console.WriteLine("the code of " + ch + (int)ch);
ch = 'A';
Console.WriteLine("the code of " + ch + (int)ch);
ch = 'B';
Console.WriteLine("the code of " + ch + (int)ch);

// STrings declaration
string firstName = "Onengibofa";
string SunName = "Omubo";
string fullName = firstName + " " + SunName;
Console.WriteLine("your first name is: " + firstName);
Console.WriteLine("your full name is: " + fullName);

//Object type declaration
object container1 = 5;
object container2 = "five";
Console.WriteLine("the object in container1 is: " + container1);
Console.WriteLine("the object in container2 is: " + container2);

// exponential declaration
float realNumber = 1.25e+1f;
Console.WriteLine(realNumber);

// Escape Sequences
char character = 'a';
Console.WriteLine(character);
character = '\'';
Console.WriteLine(character);
character = '\u003A';
Console.WriteLine(character);
character = '\\';
Console.WriteLine(character);
