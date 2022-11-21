// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//In lexicographic order the elements are compared one by onestarting from the very left. If the elements are not the same, 
//the array,whose element is smaller (comes earlier in the alphabet), comes first.If the elements are equal, 
//the next character is compared.If the end of one of the arrays is reached, without finding different elements, the shorter
//array is the smaller (comes earlier lexicographically). If all elements are equal, the arrays are equal.

int[] charArr1 = { 'a', 'b', 'c', 'd', 'e', 'f' };
int[] charArr2 = { 'a', 'b', 'c', 'd', 'e', 'f' };
if(charArr1.Length < charArr2.Length)
{
    Console.WriteLine("the first array {0} is lexicographically first ", charArr2);
}
else if(charArr2.Length < charArr1.Length)
{
    Console.WriteLine("the second array {1} is lexicographically first  ", charArr1);
}
else
{
    if (charArr1[0] < charArr2[0])
    {
        Console.WriteLine("The array index of the first array is lexicographyically first ");
    }
    else if (charArr2[0] < charArr1[0])
    {
        Console.WriteLine("The array index of the second array is lexicographyically first ");
    }
}
