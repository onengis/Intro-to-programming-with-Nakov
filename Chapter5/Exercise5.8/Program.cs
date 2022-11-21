//Write a program that, depending on the user’s choice, inputs int, double
//or string variable. If the variable is int or double, the program 
//increases it by 1. If the variable is a string, the program appends "*" at 
//the end. Print the result at the console. Use switch statement.

Console.WriteLine("Enter your value:  ");
string value = Console.ReadLine();
var result = int.TryParse(value, out int value1);
if (result)
{
    Console.WriteLine($"Your value is {value1 + 1}");
}
else
{
    result = double.TryParse(value, out double value2);
    if (result)
    {
        Console.WriteLine($"Your value is {value2 + 1}");
    }
    else
    {
        Console.WriteLine($"value is {value}*");
    }
}