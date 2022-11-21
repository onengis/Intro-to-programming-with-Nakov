// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//Write a program that prints on the console the numbers from 1 to N, 
//which are not divisible by 3 and 7 simultaneously. The number N 
//should be read from the standard input.
Console.Write("enter a number: ");
int number = int.Parse(Console.ReadLine());

int count = 35;
//while(number > i)
//{

//    count += 1;
//    Console.WriteLine(i);
//    i++;
    
//}

for(int i = 0; i < number; i++)
{
    if(i % count == 0)
    {
        Console.WriteLine(i);
    }
}