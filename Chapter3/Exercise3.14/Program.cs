// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//14 check prime number n(1<n<100
Console.Write("Enter you value :");
int value = int.Parse(Console.ReadLine());

for (int i = 2; i <= value; i++)
{
    int count = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            count++;
            if (count == 2 && i == j)
            {
                Console.WriteLine(i);

            }
            if (count == 2 && i != j)
            {
                break;
            }
        }
    }
}