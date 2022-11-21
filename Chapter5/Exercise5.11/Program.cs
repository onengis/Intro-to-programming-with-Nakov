// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//switch case
Console.Write("please enter a number: ");
int number = int.Parse(Console.ReadLine());
//int thousand = number / 1000;
int hundred = number / 100;
int tenth = number % 100;
int unit = number % 10;

if (hundred == 1)
{
    Console.Write("hundred ");
}
else if (hundred == 2)
{
    Console.Write("Two hundred ");
}
else if (hundred == 3)
{
    Console.Write("Three hundred ");
}
else if (hundred == 4)
{
    Console.Write("Four hundrd ");
}
else if (hundred == 5)
{
    Console.Write("Five hundred ");
}
else if (hundred == 6)
{
    Console.Write("Six hundred ");
}
else if (hundred == 7)
{
    Console.Write("Seven hundred ");
}
else if (hundred == 8)
{
    Console.Write("Eight hundred ");
}
else if (hundred == 9)
{
    Console.Write("Nine hundred ");
}
if (hundred >= 1 && tenth >= 1)
{
    Console.Write(" and ");
}

if (tenth >= 20 && tenth < 30)
{
    Console.Write("twenty");
}
else if (tenth >= 30 && tenth < 40)
{
    Console.Write("thirty");
}
else if (tenth >= 40 && tenth < 50)
{
    Console.Write("fourty");
}
else if (tenth >= 50 && tenth < 60)
{
    Console.Write("fifty");
}
else if (tenth >= 60 && tenth <= 70)
{
    Console.Write("sixty");
}
else if (tenth >= 70 && tenth < 80)
{
    Console.Write("sevent");
}
else if (tenth >= 80 && tenth <= 90)
{
    Console.WriteLine("eighty");
}
else if (tenth >= 90 && tenth < 100)
{
    Console.WriteLine("ninty");
}

switch (tenth)
{
    case 1:
        Console.Write("one");
        break;
    case 2:
        Console.Write("two");
        break;
    case 3:
        Console.Write("three");
        break;
    case 4:
        Console.Write("four");
        break;
    case 5:
        Console.Write("five");
        break;
    case 6:
        Console.Write("six");
        break;
    case 7:
        Console.Write("seven");
        break;
    case 8:
        Console.Write("eight");
        break;
    case 9:
        Console.Write("nine");
        break;
    case 10:
        Console.Write("ten");
        break;
    case 11:
        Console.Write("eleven");
        break;
    case 12:
        Console.Write("twelve");
        break;
    case 13:
        Console.Write("thirteen");
        break;
    case 14:
        Console.Write("fourteen");
        break;
    case 15:
        Console.Write("fifteen");
        break;
    case 16:
        Console.Write("sixteen");
        break;
    case 17:
        Console.Write("seventeen");
        break;
    case 18:
        Console.Write("eighteen");
        break;
    case 19:
        Console.Write("ninteen");
        break;
}


if (tenth > 20)
{
    switch (unit)
    {
        case 1:
            Console.Write(" one ");
            break;
        case 2:
            Console.WriteLine(" two ");
            break;
        case 3:
            Console.WriteLine(" three ");
            break;
        case 4:
            Console.WriteLine(" four ");
            break;
        case 5:
            Console.WriteLine(" five ");
            break;
        case 7:
            Console.WriteLine(" six ");
            break;
        case 8:
            Console.WriteLine(" eight ");
            break;
        case 9:
            Console.WriteLine(" nine ");
            break;
    }
}
