// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//8
Console.Write("Enter point x :");
double pointX = double.Parse(Console.ReadLine());
Console.Write("Enter point y: ");
double pointY = double.Parse(Console.ReadLine());
double result = (pointX * pointX) + (pointY * pointY);
double radius = 5;
bool isInsideCircle = Math.Sqrt(result) <= radius;
if (isInsideCircle)
{
    Console.WriteLine($"the point k({pointX},{pointY}) is inside the Circle");
}
else
{
    Console.WriteLine($"the point k({pointX},{pointY}) is out side the circle");
}