// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a program that shows the sign (+ or -) of the product of three real 
//numbers, without calculating it. Use a sequence of if operators.
int number = 1;
int number2 = 4;
int number3 = 5;
if (number < 0 && number2 < 0 && number3 < 0)
{
    Console.WriteLine("-");
}
else if (number2 > 0 && number < 0 && number3 < 0)
{
    Console.WriteLine('+');
}
else if (number3 > 0 && number > 0 && number2 > 0)
{
    Console.WriteLine("+");
}
