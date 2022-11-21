// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a method that finds the biggest element of an array. Use that 
//method to implement sorting in descending order.

int[] arr = { 1, 2, 3, 4, 5, };

int[] arrResult = GetSotedarray(arr);
int biggest = int.MinValue;
foreach(int array in arrResult)
{
    if(biggest < array)
    {
        biggest = array;
        Console.WriteLine(biggest);
    }
    //Console.WriteLine(biggest);
}

static int[] GetSotedarray(int[] arr)
{
    for(int i = 0; i < arr.Length; i ++)
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                int newNumber = arr[i];
                arr[i] = arr[j];
                arr[j] = newNumber;
            }
        }
    return arr;
}
