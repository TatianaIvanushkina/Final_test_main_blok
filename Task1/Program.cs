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
    Console.Write("Array One: [");
    for (int i = 0; i < sizeArr; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.Write("]");
} 

Console.Write("Enter character set (without spaces), click Enter ");
CreateArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);