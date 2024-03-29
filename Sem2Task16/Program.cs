﻿// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//Первый способ
void Variant1()
{
    Console.WriteLine("Способ 1");

    Console.WriteLine("Введите 1-е число: ");
    int firstNum = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Введите 2-е число: ");
    int secondNum = int.Parse(Console.ReadLine() ?? "0");

    bool test1 = (firstNum == secondNum * secondNum);
    bool test2 = (secondNum == firstNum * firstNum);

    if (test1)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    if (test2)
    {
        Console.WriteLine("Второе число квадрат первого");
    }
    if (!(test1 || test2))
    {
        Console.WriteLine("Число 1 не квадрат 2-го и число 2 не квадрат 1-го");
    }
}

//Второй способ
void Variant2()
{
    Console.WriteLine("Способ 2");
    int GetNum()
    {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    int firstNum = GetNum();
    int secondNum = GetNum();

    bool firstPow = firstNum == Math.Pow(secondNum, 2);
    bool secondPow = secondNum == Math.Pow(firstNum, 2);


    Console.WriteLine(firstPow || secondPow ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");
}

//Третий способ (Такой же как первый)
void Variant3()
{
    Console.WriteLine("Способ 3");
    int numA = int.Parse(Console.ReadLine() ?? "0");
    int numB = int.Parse(Console.ReadLine() ?? "0");
    bool test1 = (numA == numB * numB);
    bool test2 = (numB == numA * numA);

    if (test1) Console.WriteLine("Первое квадрат второго");
    if (test2) Console.WriteLine("второе квадрат первого");
    if (!(test1 || test2))
    {
        Console.WriteLine("Числа не квадраты друг друга");
    }
}

//Четвёртый способ
void Variant4()
{
    Console.WriteLine("Способ 4");
    int a = int.Parse(Console.ReadLine() ?? "0");
    int b = int.Parse(Console.ReadLine() ?? "0");

    bool test1 = a == b * b;
    bool test2 = b == a * a;

    if (test1)
    {
        Console.WriteLine("Первое квадрат второго");
    }
    else if (test2)
    {
        Console.WriteLine("Второе квадрат первого");
    }
    else
    {
        Console.WriteLine("Одно не является квадратом другого");
    }
}

Variant1();
Variant2();
Variant3();
Variant4();