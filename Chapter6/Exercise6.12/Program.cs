// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Write a program that converts a given number from decimal to binary notation (numeral system).
Console.Write("enter a number:  ");
int number = int.Parse(Console.ReadLine());
int result = number % 2;
Console.WriteLine(result);
int result1 = number / 2;;
int result2 = result1 % 2;
Console.WriteLine(result2);
int result3 =  result1 % 2;
int result4 = result1/ 2;
int result5 = result4 / 2;
Console.WriteLine(result3);
Console.WriteLine(result5);
Console.WriteLine($"Decimal number {number} to binary {result5}{result3}{result2}{result}");

int[] arr = new int[number];
for (int i = 0; i <= number; i++)
{
    arr[i] = number % 2;
    //number = number / 2;
    Console.WriteLine(arr[i]);
    number = number / 2;
}


while(number > 0)
{
    int answer = number % 2;
    Console.WriteLine(answer);
    number = number / 2;

}