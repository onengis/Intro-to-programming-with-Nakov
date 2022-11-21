// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter number3: ");
int number3 = int.Parse(Console.ReadLine());
Console.Write("Enter number4: ");
int number4 = int.Parse(Console.ReadLine());
Console.Write("Enter number5: ");
int number5 = int.Parse(Console.ReadLine());
if (number1 > number2 && number2 > number3 && number3 > number4 && number4 > number5)
{
    Console.WriteLine("Te greates number is {0}>=1", number1);
}
else if (number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
{
    Console.WriteLine("The number {0} ", number2 + " " + "is the gratest");
}
else if (number3 > number1 && number3 > number2 && number3 > number4 && number3 > number5)
{
    Console.WriteLine("The number {0}", number3 + " " + "is the greates");
}
else if(number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
{
    Console.WriteLine("The number {0} ", number4 + " " + "is the greates");
}
else if (number5 > number4 && number3 < number5 && number5 > number2 && number1 < number5)
{
    Console.WriteLine("The number {0}" + number5 + " " + " is the greatest");
}

Console.Write("please enter a value : ");
string value = Console.ReadLine();
char[] arr = value.ToCharArray();
Console.Write(arr.Length);
bool greater = true;
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] < arr[i - 1])
    {
        Console.WriteLine(i);
    }
}