// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Enter first number: ");
//int firstNumber = int.Parse(Console.ReadLine());
//Console.Write("Enter second number: ");
//int secondNumber = int.Parse(Console.ReadLine());
//Console.Write("Enter third number: ");
//int thirdNumber = int.Parse(Console.ReadLine());
//if (firstNumber > secondNumber && firstNumber > thirdNumber && thirdNumber <= secondNumber)
//{
//    Console.WriteLine("the greates number {0}, {1}, {2}", +firstNumber, secondNumber, thirdNumber);
//}
//else if (firstNumber > secondNumber && firstNumber > thirdNumber && secondNumber > thirdNumber)
//{
//    Console.WriteLine(" the greatest {0} {1}, {2} ", +firstNumber, secondNumber, thirdNumber);
//}
//else if (firstNumber < secondNumber && firstNumber > thirdNumber && thirdNumber < secondNumber)
//{
//    Console.WriteLine("the greatese {0}, {1}, {2}", +secondNumber, firstNumber, thirdNumber);
//}
//else if (firstNumber < secondNumber && firstNumber < thirdNumber && secondNumber > thirdNumber)
//{
//    Console.WriteLine("the number are in accending order {0}, {1), {2}", +secondNumber, thirdNumber, firstNumber);
//}
//else if (firstNumber < secondNumber && firstNumber < thirdNumber && thirdNumber > secondNumber)
//    Console.WriteLine("the number are in accending order of {0}, {1},{2}", +thirdNumber, secondNumber, thirdNumber);

//else if(secondNumber < thirdNumber && secondNumber < firstNumber && firstNumber < thirdNumber)
//{
//    Console.WriteLine("the number are in accending order of {0}, {1}, {2}", + thirdNumber, firstNumber, secondNumber);
//}


//Sort 3 real numbers in descending order. Use nested if statements.
//Sort 3 real numbers in descending order. Use nested if statements.
using Exercise5._4;

Console.WriteLine("Enter the length of array:  ");
int lengthOfNumber = int.Parse(Console.ReadLine());
int[] arr = new int[ lengthOfNumber ];



for(int i = 0; i<lengthOfNumber; i++)
{
    Console.Write($"enter number {i+ 1}: ");
    int number = int.Parse(Console.ReadLine());
    arr[i] = number;
}

//int[] sortedValues = SortByDescendingOrder(arr);
int[] test = Test.SortByDescendingOrder(arr);
Console.WriteLine("Sort arrays in decending order");
PrintSortededArray(test);

static int[] SortByDescendingOrder(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int k = 0; k < array.Length - 1; k++)
        {

            if (array[k] < array[k + 1])
            {
                int temporaryNumber = array[k];
                array[k] = array[k + 1];
                array[k + 1] = temporaryNumber;
            }
        }
    }
    

    return array; 
}


static void PrintSortededArray(int[] sortedValues)
{
    foreach (int sortedValue in sortedValues)
    {
        Console.Write($"{sortedValue} ");
    }
}