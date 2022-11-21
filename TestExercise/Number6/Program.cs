// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a method that returns the position of the first occurrence of an 
//element from an array, such that it is greater than its two neighbors 
//simultaneously. Otherwise the result must be -1.

int[] arr = { 1, 2, 4, 10, 3, 7, 8 };
int bigegernumber = GetBiggerThanNebor(arr);
Console.WriteLine($"The bigger number from start point is {bigegernumber}");
static int GetBiggerThanNebor(int[] arr)
{
    int startPoint = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (startPoint < arr.Length - 1 && arr.Length - 1 > arr.Length - 3)
        {
            startPoint = arr.Length - 1;
        }
        else if (startPoint < arr.Length - 3 && arr.Length - 3 > arr.Length - 1)
        {
            startPoint = arr.Length - 3;
        }
        else if (startPoint < arr[0] && arr[0] > arr[2])
        {
            startPoint = arr[0];
        }
        else if (startPoint < arr[2] && arr[2] > arr[0])
        {
            startPoint = arr[2];
        }
    }
    return startPoint;
}