// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//. Write a program that finds the greatest of given 5 numbers.

int[] number = { 1, 2, 4, 20, 6};
int max = GetBiggestNumber(number);
Console.WriteLine($"The biggest number is {max}");
static int GetBiggestNumber(int[] array)
{
    int max = int.MinValue;
    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
