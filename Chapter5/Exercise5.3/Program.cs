//Write a program that finds the biggest of three integers, using nested 
//if statements.

int[] arr = { -2, -4, -7, -1, -7, -8, -9 };
int largestNumber = GetBiggestNumber(arr);
Console.WriteLine($"The biggest number is: {largestNumber}");
int smallestNumber = GetSmallestNumber(arr);
Console.WriteLine($" The smallest number is:{smallestNumber}");

static int GetSmallestNumber(int[] array)
{
    int min = int.MaxValue;
    for(int i =0; i < array.Length; i++)
    {
        
        if(min > array[i])
        {
            
            min = array[i];
            
        }
    }
    return min;
    
}

static int GetBiggestNumber(int[] matrix)
{
    int max = int.MinValue;
    for(int i = 0; i<matrix.Length; i++)
        if (max < matrix[i])
        {
            max = matrix[i];
        }
    return max;
}