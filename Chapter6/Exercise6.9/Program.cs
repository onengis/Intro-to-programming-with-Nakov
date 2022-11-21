//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Write a program that for a given integers n and x, calculates the sum: 
// S = 1 + 1!/X^n + 2!/x^n + ....n!/X^n


//Console.Write("enter N number:  ");
//int nNumber = int.Parse(Console.ReadLine());
//int nFactorial = 1;
//while(nNumber > 0)
//{
//    nFactorial *= nNumber;
//    Console.WriteLine(nFactorial);
//    nNumber--;
//}
//Console.Write("enter x number:  ");
//int xnumber = int .Parse(Console.ReadLine());
//Console.WriteLine(nFactorial/(xnumber^nNumber));

Console.Write("enter N number:  ");
int nNumber = int.Parse(Console.ReadLine());
Console.Write("enter x number:  ");
int xnumber = int .Parse(Console.ReadLine());
double result = SumFractions(nNumber, xnumber);

Console.WriteLine($"the result is {result}");

static int Factorial(int number)
{
    int nFactorial = 1;
    while (number > 0)
    {
        nFactorial *= number;
        number--;
    }

    return nFactorial;
}

static double SumFractions(int n, int x)
{
    double sum=1;
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(Factorial(i) );

        sum += (Factorial(i) / Math.Pow(x, i));
    }

    return sum;
}
