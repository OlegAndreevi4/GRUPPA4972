﻿// #69 Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии.


// Первый вариант
// long RecPow(int a, int b)
// {
//     long res = 1;
//     if (b > 0)
//     {
//         return 1;
//     }
//     else
//     {
//         res = a * RecPow(a, b - 1);
//     }
//     return res;
// }

//Второй вариант
// long MyPow(int a, int b)
// {
//     if (b = 2) return a * a;
//     if (b = 1) return a;
//     if (b % 2 == 0)
//     {
//         return MyPow(a, b / 2) * MyPow(a, b / 2);
//     }
//     else
//     {
//         return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
//     }
// }


// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Считает сумму
int Exponentiation(int number, int stepen)
{
    return stepen <= 0 ? 1 : number * Exponentiation(number, stepen - 1);
}

// Считает сумму
int Exponentiation1(int number, int stepen)
{
    return stepen == 2
    ? number * number
    : stepen <= 1
        ? number
        : stepen % 2 == 0
            ? Exponentiation1(number, stepen / 2) * Exponentiation1(number, stepen / 2)
            : Exponentiation1(number, stepen / 2 + 1) * Exponentiation1(number, stepen / 2);
}

long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    if (b == 1) return a;

    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
    }
}


int number = Prompt("Введите число: ");
int stepen = Prompt("Введите степень: ");

Console.WriteLine($"Число {number} в степени {stepen} = {Exponentiation(number, stepen)}");
Console.WriteLine($"Число {number} в степени {stepen} = {MyPow(number, stepen)}");