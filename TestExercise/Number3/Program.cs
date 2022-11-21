// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a method that returns the English name of the last digit of a 
//given number. Example: for 512 prints "two"; for 1024  "four".

Console.Write("enter a number to be converted to word: ");
int number = int.Parse(Console.ReadLine());
int resultInWord = GetWord(number);
Console.WriteLine(resultInWord);
static int GetWord(int number)
{
    int value = number % 10;
    switch (value)
    {
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        case 3:
            Console.WriteLine("Three");
            break;
        case 4:
            Console.WriteLine("Four");
            break;
        case 5:
            Console.WriteLine("Five");
            break;
        case 6:
            Console.WriteLine("Six");
            break;
        case 7:
            Console.WriteLine("Seven");
            break;
        case 8:
            Console.WriteLine("Eight");
            break;
        case 9:
            Console.WriteLine("Nine");
            break;
       
    }
    return value;
}