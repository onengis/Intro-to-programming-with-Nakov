Console.Write("enter a number to calculate factorial:  ");
int number = int.Parse(Console.ReadLine());


long factorialResults = CalculateFactorial(number);

int numberOfZeros = GetNumberOfZeroesInFactorial(factorialResults);

Console.WriteLine(numberOfZeros);

static long CalculateFactorial(int number)
{
    long factorial = 1;
    while (number > 0)
    {
        factorial *= number;
        number--;
    }
    return factorial;
}

static int GetNumberOfZeroesInFactorial(long factorialResults)
{
    string numInString = factorialResults.ToString();
    int count = 0;
    for (int i = numInString.Length-1; i > 0; i--)
    
        if (numInString[i] == '0')
        {
            count++;
        }
        else
        {
            return count;
        }
    

    return count;
}