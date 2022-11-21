// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Area and Perimeter of a circle
Console.Write("Enter radius of a circle :");
double radius = double.Parse(Console.ReadLine());
double area = Math.PI * radius * radius;
Console.WriteLine(area);

double perimeter = 2 * radius * Math.PI;
Console.WriteLine(perimeter);