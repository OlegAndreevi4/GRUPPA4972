﻿// Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

﻿// Вывод сообщения и запись введённых данных


// String RecMN(int n, int m)
// {
//     String res = String.Empty;
//     if(n<=m)
//     {
//         res = n;
//     }
//     else
//     {
//     res =m + "_"+ RecMN(n, m+1);
//     }
// return res;
// }




int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Формирование строки с числами
string SearchForNaturalElementsRec (int m, int n)
{
    return n >= m ? $"{m} " + SearchForNaturalElementsRec(m + 1, n) : "";
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

Console.WriteLine((m>n)?SearchForNaturalElementsRec(n, m):SearchForNaturalElementsRec(m, n));