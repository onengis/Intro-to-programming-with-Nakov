// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the length of fibonacci series:  ");
int length = int.Parse(Console.ReadLine());
int firstNumber = 0;
int secondNumber = 1;
int result = 0;
int count = 0;

for(int i = 0; i < length; i++)
{
    
    Console.WriteLine(firstNumber);
    result = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = result;
    //Console.WriteLine(secondNumber);
    //count++;
}