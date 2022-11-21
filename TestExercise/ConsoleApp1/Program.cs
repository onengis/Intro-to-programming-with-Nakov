// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//9
Console.Write("Enter poin x: ");
double pointX = double.Parse(Console.ReadLine());
Console.Write("Enter point y :");
double pointY = double.Parse(Console.ReadLine());
double radius = 5;
double result = pointX * pointX + pointY * pointY;
bool insideTheCircle = Math.Sqrt(result) <= radius;
bool outsideOfRectangle = pointX < -1 && pointX > radius && pointY < 1 && pointY > radius;
if (insideTheCircle)
{
    Console.WriteLine("the point +" + (pointX,pointY) +"IS :" + insideTheCircle + " and is inside the circle");
}
else
{
    Console.WriteLine("the point "+ (pointX, pointY)+  "is :" + insideTheCircle + " is outside the circle");
}

if(outsideOfRectangle)
    { 
    Console.WriteLine("The point "+ (pointX, pointY) + "is :" + outsideOfRectangle + "and is outside the rectangle");
}
else
{
    Console.WriteLine(" the point " + (pointX, pointY) + "is : " + outsideOfRectangle + " is " + pointX, pointY);
}