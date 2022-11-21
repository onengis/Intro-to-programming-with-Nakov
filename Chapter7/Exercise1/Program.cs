// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals 
//to the index of the element multiplied by 5. Print the elements to the console.

int[] arrv = new int[20];
for (int index = 0; index < arrv.Length; index++)
{
    Console.Write(index * 5 + " ");
}