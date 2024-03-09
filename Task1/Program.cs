// Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.Runtime.ExceptionServices;
int sizeArr = 5;
int n = 3;
string[] arrayOne = new string[sizeArr];

void CreateArray(string[] arr) 
{
    for (int i = 0; i < sizeArr; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr)
{
    int arrLen = arr.Length;
    Console.Write("[");
    for (int i = 0; i < arrLen; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.Write("]");
} 

int GetSizeArrayTwo(string[] arr)
{
    int count = 0;
    for (int i = 0; i < sizeArr; i++)
    {
        if(arr[i].Length <= n)
        {
            count = count + 1;  
        }
    }
    return count;
}

string[] CreateArrayTwo(string[] arr)
{
    string[] arrayTwo = new string[GetSizeArrayTwo(arrayOne)];
    for (int i = 0, j = 0; i < sizeArr; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j = j + 1; 
        }
    }
    return arrayTwo;
}


Console.Write("Enter character set (without spaces), click Enter ");
Console.WriteLine();
CreateArray(arrayOne);
Console.Clear();
Console.WriteLine ("Array One: ");
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine ("Array Two: ");
if(GetSizeArrayTwo(arrayOne) == 0)
{
    Console.Write("There are no lines whose length is less than or equal to 3 characters");
}
else
{
    string[] arrayTwo = CreateArrayTwo(arrayOne);
    PrintArray(arrayTwo);
}
