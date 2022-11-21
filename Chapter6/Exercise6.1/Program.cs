// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Write a program that prints on the console the numbers from 1 to N. 
//The number N should be read from the standard input.

Console.Write("enter a number:  ");
int number = int.Parse(Console.ReadLine());
while(number > 0)
{
    Console.WriteLine(number);
    number--;
}