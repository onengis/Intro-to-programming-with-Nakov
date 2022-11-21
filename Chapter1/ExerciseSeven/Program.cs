// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Good Morning");
Console.WriteLine("Good Afternoon");
Console.WriteLine("Good Evening");

//My First Name and My second name
Console.WriteLine("Onengibofa Omubo");

// Printe 1, 101, 1001 on a new line
Console.WriteLine("1\n101\n1001");

// Current date and time
Console.WriteLine(System.DateTime.Now);

// Square root of 1234
int num;
num = 1234;
double num1 = Math.Sqrt(num);

// The first 100 numbers
int num12 = 100;
for(int i = 2; i < num; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine("- {0}", i);
    }
}

//printe your age
Console.Write("enter your DOF : ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Your ae after 10 years is {0}", + age + 10);
