// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Write a program that calculates N!*K!/(N-K)! for given N and K 
//(1 < K < N).

Console.Write("enter N number:  ");
int number = int.Parse(Console.ReadLine());
int nfactorial = 1;
for(int i = 1; i < number; i++)
{
    nfactorial *= i;
}
Console.Write("enter K number:  ");
int kNumber = int.Parse(Console.ReadLine());
int kfactorial = 1;
for(int j = 1; j < kNumber; j++)
{
    kfactorial *= j;
}
int jNumber = nfactorial * kNumber;
int factorialN_K = number - kNumber;
int factorial = jNumber / factorialN_K;
Console.WriteLine($"The factorial of N!* K!/(N-K)! =  {factorial}");