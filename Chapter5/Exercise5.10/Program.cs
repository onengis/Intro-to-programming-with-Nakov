// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a program that applies bonus points to given scores in the range 
//[1…9] by the following rules:
//-If the score is between 1 and 3, the program multiplies it by 10.
//- If the score is between 4 and 6, the program multiplies it by 100.
//- If the score is between 7 and 9, the program multiplies it by 1000.
//- If the score is 0 or more than 9, the program prints an error 
//message.

Console.Write("Please enter a number:  ");
int number = int.Parse(Console.ReadLine());
if (1 <= number && number <= 3)
{
    Console.WriteLine(number * 10);
}
else if (4 <= number && number <= 6)
{
    Console.WriteLine(number * 100);
}
else if (7 <= number && number <= 9)
{
    Console.WriteLine(number * 1000);
}
else
    Console.WriteLine("input erro");