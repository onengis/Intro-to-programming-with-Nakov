// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("enter first term:  ");
double firestTerm = double.Parse(Console.ReadLine());
Console.Write("enter second term:  ");

double secondterm = double.Parse(Console.ReadLine());
Console.Write("Enter nth term:  ");
double nTh = double.Parse(Console.ReadLine());
double sum = 0;

for (double i = 1; i <= nTh; i++)
{
    double commonD = secondterm - firestTerm;
    sum = (nTh / 2) * (2 * firestTerm + (nTh - 1) * commonD);
    Console.WriteLine(i);
    Console.WriteLine(sum);
}

for(double i = 1; i <= nTh; i++)
{
    double commonD = secondterm - firestTerm;
    sum = firestTerm / (1 - commonD);
    Console.WriteLine(sum);

}