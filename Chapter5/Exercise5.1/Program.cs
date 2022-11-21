// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1 = 5;
int number2 = 6;
int biggerNumber = number1;
if(number1 < number2)
{
    biggerNumber = number2;
    number1 = number2;
    Console.WriteLine("Number1 {0} is the greatest ", +  number1);
}