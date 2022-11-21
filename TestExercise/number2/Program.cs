// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Create a method GetMax() with two integer (int) parameters, that
//returns maximal of the two numbers. Write a program that reads three 
//numbers from the console and prints the biggest of them. Use the 
//GetMax() method you just created. Write a test program that validates 
//that the methods works correctly

int[] arr = { 4, 5, 6, 90, 800 };
//Console.Write("Enter a number to comapare :  ");
//int startNumber = int.Parse(Console.ReadLine());
//int larggestNumber = GetMaxNumberInArray(arr);
//int maximumNumber = GetMaxNumber(number,number2);
int result = FindMax(arr);
Console.WriteLine($"{result}");
static int GetMaxNumber(int a, int b )
{
    int biggest = 0;
    if(  a > b)
    {
        biggest = a;
    }
    else
    {
        biggest = b;
    }
    return biggest;
}

//static int GetMaxNumberInArray(int[] array)
//{
//    int max = int.MinValue;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (max < array[i])
//        {
//            max = array[i];
//        }
//    }
//    return max;
//}

static int FindMax(int[] array)
{
    //int startIndex = 0;
    int currentItem = 0;
    int maximumNumber = int.MinValue;
    for(int i = 0; i < array.Length; i++)
    {
        //startIndex = startNumber;
        currentItem = array[i];
        maximumNumber = GetMaxNumber(maximumNumber, currentItem);
    }
    return maximumNumber;
}