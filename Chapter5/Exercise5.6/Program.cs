
//.Write a program that gets the coefficients a, b and c of a quadratic 
//equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
//Quadratic equations may have 0, 1 or 2 real roots.


Console.Write("Enter the number a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Enter the number b: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Enter the number c: ");
int numberC = int.Parse(Console.ReadLine());
double result = Determinaat(numberA, numberB, numberC);
double[] resultOfQudraticEquations = ResultOfEquations(result, numberB , numberA);
foreach(double resultOfEquation in resultOfQudraticEquations)
{
    Console.WriteLine(resultOfEquation);
}
static double Determinaat(int a, int b, int c)
{
    double resultOfDeterminant = Math.Pow(b, b) - 4 * a * c;
    if(resultOfDeterminant < 0)
    {
        Console.WriteLine("There is no real root");
    }
    return resultOfDeterminant;
}
static double[] ResultOfEquations(double result, int b, int a)
{
    double squareOfResult = Math.Sqrt(result);
    double denominator = 2 * a;
    double root1 = (-b + (squareOfResult)) / denominator;
    double root2 = (-b - (squareOfResult)) / denominator;
    double positiveRoot = root1;
    double nagetiveRoot = root2;
    double[] resultOfEquations = { nagetiveRoot, positiveRoot };
    return resultOfEquations;
}
