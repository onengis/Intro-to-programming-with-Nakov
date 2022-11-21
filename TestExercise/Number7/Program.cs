//Write a method that prints the digits of a given decimal number in a 
//reversed order. For example 256, must be printed as 652.


int number = 652;
int[] resultOfNumber = GetReversedOrder(number);
foreach (int result in resultOfNumber)
{
    Console.Write(result + " ");
}

static int[] GetReversedOrder(int number)
{
    int numberA = number % 10;
    int numberB = number / 10;
    int numberD = numberB % 10;
    int numberC = number / 100;
    int[] result = { numberA, numberD, numberC };
    return result;
}
