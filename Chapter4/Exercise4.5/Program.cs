// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("enter value: ");
int value = int.Parse(Console.ReadLine());
Console.Write("enter value1 :");
int value1 = int.Parse(Console.ReadLine());
int divisor = 5;
for(int i = 0; i < value1; i++)
{
    if(i % divisor == 0 && value < i && i <= value1)
    {
        Console.WriteLine(i);
    }
}
