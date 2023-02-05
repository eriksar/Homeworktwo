﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));


// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Вы не ввели третье число: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
