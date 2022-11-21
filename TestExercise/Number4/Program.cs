// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a method that finds how many times certain number can be 
//found in a given array. Write a program to test that the method works 
//correctly.

int[] arr = { 1, 2, 4, 1, 5, 6, 1, 8 };
Console.Write("Enter a number to check how many time it appear: ");
int number = int.Parse(Console.ReadLine());
int result = GetDuplicate(arr, number);
Console.WriteLine($"The number {number} appear {result} times.");
static int GetDuplicate(int[]arr, int number)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (number == arr[i])
        {
            count++;
        }
    }
    return count;
}