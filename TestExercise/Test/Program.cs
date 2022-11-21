// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int[] arr = { 2, 1, 6, 4, 5 };
//int results = GetSubSet(arr);
//int[] arrNumber = new int[results];
//static int GetSubSet(int[] arr)
//{
//    int start = 0;
//    for (int i = 0; i < arr.Length-1; i++)
//    {
//        for (int j = i+1; j < arr.Length; j++)
//        {
//            start = arr[j];
//            Console.WriteLine($"{arr[i]} {start}");
//        }
//    }
//    return start;
//}


int number = 1000000;
string NumberInWord = GetNumberInWord(number);
Console.WriteLine(NumberInWord);
static string GetNumberInWord(int number)
{
    while(number>0)
    {
        number = number / 1000000;
        if(number == '0')
        {
            number = " One Million";
        }

    }
    return number;
}
