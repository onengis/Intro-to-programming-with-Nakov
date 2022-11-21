// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when 
//they are of equal length and all of their elements, which have the same index, are equal).

Console.Write("Enter the length of Array 1:   ");
int arrA = int.Parse(Console.ReadLine());
int[] arrLengthA = new int[arrA];
bool equall = true;
for (int index = 0; index < arrLengthA.Length; index++)
{
    Console.Write(index + " ");
    
}
Console.WriteLine(" ");
Console.Write("Enter the length of Array 2:   ");
int arrB = int.Parse(Console.ReadLine());
int[] arrLengthB = new int[arrB];
if(arrLengthA != arrLengthB)
{
    Console.WriteLine("The arrays are of different Length");
    for(int i = 0; i < arrLengthB.Length; i++)
    {
        Console.Write(i + " ");
    }
}
else if(arrLengthA == arrLengthB)
{
    Console.WriteLine("The arrays are of equall size");
    for (int index = 0; index < arrLengthA.Length; index++)
    {
        Console.Write(index + " ");
    }
}