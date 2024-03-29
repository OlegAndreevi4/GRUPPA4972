﻿// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Генерация массива
int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

//[1 2 3 4 5] 
//[5  4  3  2  1 ]

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i =0; i <arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }

    return outArr;
}

void SwapArray(int[] arr)
{
    //int buferElement = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        (arr[arr.Length-1 - i],arr[i])=(arr[i],arr[arr.Length-1 - i]);
                     // ИЛИ
        // buferElement = arr[arr.Length-1 - i];
        // arr[aee.Length-1 -i] = arr[i];
        // arr[i] = buferElement;
    }
}

int[] arr =GenerateRandomArray(15,1,100);
PrintArray("",arr);
int[] swapArr = SwapNewArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);
Console.WriteLine("Перевёрнутый массив");
PrintArray("",swapArr);

SwapArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);
