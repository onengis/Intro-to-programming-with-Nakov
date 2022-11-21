// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// In combinatorics, the Catalan numbers are calculated by the following formula: 
//Cn = i/ (n+1)(2n/n) = 2n!/(n+1)!n! or n ≥ 0. Write a program that calculates the nth Catalan number by given n.
Console.Write("enter N number: ");
int nNumber = int.Parse(Console.ReadLine());
int nValue = nNumber + 1;
int factorial = 1;
int factorial2 = 1;
while(nValue > 0)
{
    factorial *= nValue;
    Console.WriteLine(factorial);
    nValue--;
}

double factorialX2 = (factorial);
Console.WriteLine(factorialX2);

while(nNumber>0)
{
    factorial2 *= nNumber;
    Console.WriteLine(factorial2);
    nNumber--;
}
