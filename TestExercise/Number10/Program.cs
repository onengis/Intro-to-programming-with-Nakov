// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a program that calculates and prints the n! for any n in the range
//[1…100].

Console.Write("Enter a number to calculate factorial:  ");
int number = int.Parse(Console.ReadLine());

long result = GetFactorial(number);
Console.WriteLine("the factorial of {0} is: {1}", number, result);
static long GetFactorial(int number)
{
    long factorial = 1;
    while (number > 0)
    {
        factorial *= number;
        number--;
    }
    return factorial;
}



