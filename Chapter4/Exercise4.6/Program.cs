// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("enter number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("enter number2: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("the gratest number is: {0}", Math.Max(number1, number2) );