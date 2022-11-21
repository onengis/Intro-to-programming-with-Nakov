// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Write a program that calculates N!/K! for given N and K (1<K<N).
Console.Write("enter n number:  ");
int nNumber = int.Parse(Console.ReadLine());
int nfactorial = 1;
for (int i = 1; i<=nNumber; i++)
{
    nfactorial *= i;
    Console.WriteLine( nfactorial);
}
Console.Write("enter k number:  ");
int kNumber = int.Parse(Console.ReadLine());
int kfactorial = 1;
for (int j = 1; j <= kNumber; j++)
{
    kfactorial *= j;
    int sum = kfactorial;
    Console.WriteLine(sum);
}
Console.WriteLine("The factorial of N!/K! ", nfactorial / kfactorial);