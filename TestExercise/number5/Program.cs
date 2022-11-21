// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Write a method that checks whether an element, from a certain position 
//in an array is greater than its two neighbors. Test whether the 
//method works correctly.

int[] arr = { 1, 2, 4,8, 6, 3, 7, 8 };
//Console.Write("Enter a number to check the greatest value:  ");
int index = -3; //int.Parse(Console.ReadLine());
bool isBigger = GetBiggerThanNebor(arr, index);

if(isBigger)
{
    Console.WriteLine($"The number {arr[index]} is bigger than its neighbours");
}
  
static bool GetBiggerThanNebor(int[] arr, int index)
{
    if(index == 0 || index == arr.Length-1)
    {
        Console.WriteLine("index don't have two neighbours");
        return false;
    }
    else if(index <0 || index > arr.Length-1)
    {
        Console.WriteLine("index out of range");
    }
    else
    {
        if(arr[index] > arr[index+1] && arr[index] > arr[index-1])
        {
            return true;
        }
        else
        {
            Console.WriteLine($"The number {arr[index]} is not bigger than its neighbours");
        }
    }
    return false;
}
