// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Write a program that reads from the console a positive integer number 
// N(N < 20) and prints a matrix of numbers as on the figures below:

Console.Write("Enter the length of array:  ");
int arrLength = int.Parse(Console.ReadLine());

var result = GetSquareArray(arrLength);

for (int i = 0; i < arrLength; i++)
{
    for (int k = 0; k < arrLength; k++)
    {

        Console.Write($"{result[i, k]} ");
    }
    Console.WriteLine();
}

static int[,] GetSquareArray(int n)
{
    int col = n;
    int row = n;
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < col; k++)
        {

            array[i, k] = i + k + 1;
        }
    }

    return array;
}