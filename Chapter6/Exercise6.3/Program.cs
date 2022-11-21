// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Write a program that reads from the console a series of integers and 
//prints the smallest and largest of them.
Console.Write("enter lenght of number:  ");
int lenghtNumber = int.Parse(Console.ReadLine());
int[] arr= new int[lenghtNumber];
for (int i = 0; i < lenghtNumber; i++)
{
    Console.Write($"enter number {i + 1}:  ");
    int number1 = int.Parse(Console.ReadLine());
    arr[i] = number1;
}
// 1 2 5 3 7 0 8 2
int maxNumber = GetMaxNumber(arr);
int minNumber = GetMinNumber(arr);
Console.WriteLine($"The largest number is {maxNumber}, and the smallest number is  {minNumber}");

static int GetMinNumber(int[] array)
{
    int minValue = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }

    return minValue;

}

static int GetMaxNumber(int[] array)
{
    int maxValue = int.MinValue;
    for(int i = 0; i < array.Length;i++)
    {
        if (array[i] > maxValue )
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}