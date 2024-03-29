﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] array2D = new int[n, m];
        int element = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array2D[i, j] = element;
                element = element + k;
            }
        }
        return array2D;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        int[] result = new int[2];
        if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
        {
            result[0] = 0;
            result[1] = 1;
        }
        else
        {
            result[0] = matrix[rowPosition - 1, columnPosition - 1];
            result[1] = 0;
        }
        return result;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        if (results[1] != 0)
        {
            Console.WriteLine("There is no such index");
        }
        else
        {
            Console.WriteLine("The number in [" + X + ", " + Y + "] is " + results[0]);
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 8;
            y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}