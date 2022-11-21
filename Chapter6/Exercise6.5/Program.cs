// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Write a program that reads from the console number N and print the sum 
//of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
//13, 21, 34, 55, 89, 144, 233, 377, …
Console.Write("enter lenght of number: ");
int number = int.Parse(Console.ReadLine());
int value = 0;
int value1 = 1;
int result = 1;
Console.WriteLine(value);
for(int i = 0; i < number; i++)
{
    Console.WriteLine(result);
    result = value + value1;
    value = value1;
    value1 = result;

}