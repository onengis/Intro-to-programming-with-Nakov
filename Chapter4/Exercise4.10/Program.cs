// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter n value:  ");
int value = int.Parse(Console.ReadLine());
for (int i = 1; i < value; i++)
{
    Console.WriteLine(i);
}