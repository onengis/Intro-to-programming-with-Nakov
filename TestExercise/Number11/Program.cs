// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a program that solves the following tasks:
//-Put the digits from an integer number into a reversed order.
//- Calculate the average of given sequence of numbers.
//- Solve the linear equation a * x + b = 0.
//Create appropriate methods for each of the above tasks.
//Make the program show a text menu to the user. By choosing an option 
//of that menu, the user will be able to choose which task to be invoked.

Console.WriteLine("Choose an option to perform a task");
Console.WriteLine("ReversOrder 1");
Console.WriteLine("CalAverage 2");
Console.WriteLine("Linear Equation 3");
string? option = Console.ReadLine();
PerformATask(option);

static void PerformATask(string? option)
{
    if (option == "1")
    {
        int number = 652871;
        int[] results = NewReversOrder(number);
        PrintInReversOrder(results);
    }
    else if(option == "2")
    {
        Console.WriteLine("Calculate the average of given sequence of numbers.");
        int number = 4;
        int[] result = GetArray(number);
        double average = CalAverage(result);
        Console.WriteLine($"The averag resut of N number is {average}");
    }
    else if(option == "3")
    {
        Console.WriteLine("Solve the linear equation a * x + b = 0.");
        int numberA = 10;
        int numberB = 5;
        double result = LinearEquation(numberA, numberB);
        Console.WriteLine($"The value of x in the lenear equation is {result}");

    }
    else
    {
        Console.WriteLine("invalid input");
    }
}

static void PrintInReversOrder(int[] results)
{
    foreach(int result in results)
    {
        Console.Write(result + " ");
    }
}

static int[] NewReversOrder(int number)
{
    int numberOfDigit = number.ToString().Length;
    int[] result = new int[numberOfDigit];
    int i = 0;
    int division = 1;

    while(i < numberOfDigit)
    {
        result[i] = (number / division) % 10;
        i++;
        division *= 10;
    }

    return result;
}

static int[] ReversOrder(int number)
{

    int numberA = number % 10;  // 652 256
    int numberB = number / 10;
    int numberD = numberB % 10;
    int numberC = number / 1000;
    int[] result = { numberA, numberD, numberC };
   
    return result;
}

static int[] GetArray(int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter number{i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}
static double CalAverage(int[] array)
{
    double total = 0;
    double average = 0;
    for (int i = 0; i < array.Length; i++)
    {
        total += array[i];
    }
    average = total / array.Length;
    return average;
}

static double LinearEquation(int a, int b)
{
    double x = - a / b;
    return x;
}