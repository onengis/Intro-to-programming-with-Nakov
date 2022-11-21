// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Write a program that asks for a digit (0-9), and depending on the input,
//shows the digit as a word (in English). Use a switch statement.
Console.Write("Please enter a number: ");
int number = Int32.Parse(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("Yur entered number one");
        break;
        case 2:
        Console.WriteLine("You enterd number Two");
        break ;
        case 3:
        Console.WriteLine("You enterd number Three");
        break ;
    case 4:
        Console.WriteLine("You enterd number Four");
        break ;
    case 5:
        Console.WriteLine("You enterd number Five");
        break ;
    case 6:
        Console.WriteLine("You enterd number Six");
        break ;
    case 7:
        Console.WriteLine("You enterd number Seven");
        break ;
    case 8:
        Console.WriteLine("You enterd number Eight");
        break ;
    case 9:
        Console.WriteLine("You enterd number Nine");
        break ;
        default: Console.WriteLine("invalide input");
        break;


}