// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter a number : ");
int number = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Enter third Number : ");
int thirdNumber = int.Parse(Console.ReadLine());
int sum = number + secondNumber + thirdNumber;
Console.WriteLine(sum);