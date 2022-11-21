//We are given 5 integer numbers. Write a program that finds those 
//subsets whose sum is 0. Examples:
//-If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
//is 0.
//- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
//with sum 0.
int[] arr = { 3, -2, 1, 1, -2, 8 };
List<Tuple<int, int>> indexValue = FindFirstSubsetEqualsZero(arr);
PrintSubset(indexValue, arr);

static List<Tuple<int, int>> FindFirstSubsetEqualsZero(int[] array)
{
    int firstIndex = 0;
    int lastIndex = 0;
    List<Tuple<int, int>> result = new List<Tuple<int, int>>();

    for (int i = 0; i < array.Length; i++)
    {
        int sum = array[i];
        firstIndex = i;
        for (int j = i+1; j < array.Length; j++)
        {
            sum += array[j];
            if (sum == 0)
            {
                lastIndex = j;
                result.Add(Tuple.Create(firstIndex, lastIndex));
            }
        }
    }

    return result;

}

static void PrintSubset(List<Tuple<int, int>> results, int[] array)
{
    foreach (var result in results)
    {
        int startIndex = result.Item1;
        int stopIndex = result.Item2;
        for (int i = startIndex; i <= stopIndex; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    

}