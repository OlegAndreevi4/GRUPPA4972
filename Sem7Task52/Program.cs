﻿// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям 
// и диагональ выделить разным цветом.

// Иван

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// // Заполнение случайными числами
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }
// // вывод матрицы с цветным и диаганалями
// void PrintArray (int [,] matrix)
//     {
//         ConsoleColor mainDiagColor = ConsoleColor.Yellow;
//     ConsoleColor secondDiagColor = ConsoleColor.DarkBlue;
//     ConsoleColor defaultColor = ConsoleColor.Gray;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.ForegroundColor = 
//             (i == j)? mainDiagColor:
//             (i+j == matrix.GetLength(1)-1)?secondDiagColor: 
//             defaultColor;
//             Console.Write(matrix[i,j]+"\t");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }
//   // Печать средних по столбцам
//   void  PrintListAvr (double [] list)
//     {
//       Console.WriteLine("The averages in columns are: ");
//       for(int i = 0; i < list.Length; i++)
//         Console.Write(list[i].ToString("0.00")+"\t");

//         Console.WriteLine();    
//     }
//   // Поиск средних по столбцам
//   double [] FindAverageInColumns (int [,] matrix)
//     { 
//       double[] result = new double[matrix.GetLength(1)];
//       for(int j = 0; j < matrix.GetLength(1); j++)
//       {
//         result[j] = 0;
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//           result[j] +=matrix[i,j];
//         }
//         result[j]/=matrix.GetLength(0);
//       }
//       return result;
//     }
// //Поисх средних по диаганалями
// double[] AveragesInDiaganals(int [,] matrix)
// {

//     double[] result = {0,0};
//     int numVal = matrix.GetLength(1) < matrix.GetLength(0) ? matrix.GetLength(1): matrix.GetLength(0);
//     for(int j = 0; j < matrix.GetLength(1); j++) // пробегаем по диаганалям
//     {
//          if(j < numVal) 
//            result[0] += matrix[j,j]; // накладываем условия, чтобы не вылезти за границы
//          if(matrix.GetLength(0) > matrix.GetLength(1)-1-j) // накладываем условия, чтобы не вылезти за границы
//             result[1] += matrix[matrix.GetLength(1)-1-j, j]; 
//     }
//     result[0]/=numVal;
//     result[1]/=numVal;
//     return result;
// }
// //печать средних по диаганалям
//  void  PrintDiagAverages (double [] diagAvg)
//     {
//         Console.WriteLine($"Среднее на главной диаганали: {diagAvg[0].ToString("0.00")}, а среднее по побочной: {diagAvg[1].ToString("0.00")}");
//     }

//    Console.Clear();
// int n = ReadData("Введите количество строк");
// int m = ReadData("Введите количество стобцов");
// int[,] arr2D = Fill2DArray(n,m,10,-10);
// PrintArray(arr2D);
// double[] avgArr = FindAverageInColumns(arr2D);
// PrintListAvr(avgArr);
// double[] avgDiag = AveragesInDiaganals(arr2D);
// PrintDiagAverages(avgDiag);


public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}" + "\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] newMatrix = new int[n, m];
        int currentValue = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = currentValue;
                currentValue += k;
            }
        }
        return newMatrix;
    }

    static void PrintListAvr(double[] list)
    {
        Console.WriteLine("The averages in columns are: ");
        foreach (double el in list)
        {
            Console.Write($"{el:f2}" + "\t");

        }
        Console.WriteLine();
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        double arithMean = 0;
        double[] result = new double[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arithMean = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                arithMean = arithMean + matrix[i, j];
            }
            result[j] = arithMean / matrix.GetLength(0);
        }
        return result;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}
