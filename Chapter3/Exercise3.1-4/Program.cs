// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//1
int value = 30;
int number = value % 2;
Console.WriteLine(number);
Console.WriteLine("the number : " + value + "is an even number.");

//2
bool result = (40 % 5 == 0) && (40 % 7 == 0);
Console.WriteLine(result);

//3
string num = "56789";
int numLength = num.Length;
if(numLength >= 3)
{
    if (num[numLength-3] == '7')
    {
        Console.WriteLine("it contains 7");
    }
    else
    {
        Console.WriteLine("it does not contains 7");
    }
}
else
{
    Console.WriteLine("out of scope");
}

//4

//5 trapizoid
double pararel1 = 3;
double pararell2 = 5;
double height = 4;
double trapizoidArea = (1/2)*(pararel1 + pararell2) * height;
Console.WriteLine(trapizoidArea);

//6 Area and Perimeter of Rectangle
int width = 4;
int lenght = 7;
int areaOfRectangle = width * lenght;
Console.WriteLine("Area of Rectangle: {0}",areaOfRectangle);
int perimeter = 2 * (width + lenght);
Console.WriteLine(perimeter);



//Console.WriteLine("enter your numbber :");
//int value1 = int.Parse(Console.ReadLine());
//int sum1 = 0;
//for(int i = 0; i < value1; i++)
//{
//    int number1 = int.Parse(Console.ReadLine());
//    sum1 = number1 + number1 + number1 + number1;
//}
//Console.WriteLine(sum1);

Console.WriteLine("enter your value :");
int fourdigit = int.Parse(Console.ReadLine());
int result1 = fourdigit % 10;
int result2 = (fourdigit / 10)%10;
int result3 = (fourdigit / 100)%10;
int result4 = (fourdigit / 1000) % 10;
int sumResult = result4 + result1 + result2 + result3;
Console.WriteLine(sumResult);
Console.WriteLine($"print result in reverse order : {result1}{result2}{result3}{result4}");





string str = "2011";
char[] arr= str.ToCharArray();
int sum = 0;

int val= arr[arr.Length-1];

for (int i = 0; i < arr.Length; i++)
{
    sum =sum+ (int)arr[i];

}
Console.WriteLine(sum);