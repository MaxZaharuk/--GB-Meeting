/*
Урок 2. Базовые алгоритмы
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


void FindMiddle(string num)
{
    int number;
    int.TryParse(num, out number);
    while (number < 100 || number > 999)
    {
        Console.WriteLine("Неверный ввод! Введите число от 100 до 999: ");
        num = Console.ReadLine() ?? "0";
        int.TryParse(num, out number);
    }
    int middle = number % 100 / 10;
    Console.WriteLine($"Вторая цифра числа {number} - {middle}");
}


void FindThird(string num1)
{
    int number;
    int.TryParse(num1, out number);
    while (number == 0)
    {
        Console.WriteLine("Неверный ввод! Введите число, не равное нулю: ");
        num1 = Console.ReadLine() ?? "0";
        int.TryParse(num1, out number);
    }
    int length = num1.Length;
    if (number < 0)
    {
        length -= 1;
    }

    if (length < 3)
    {
        Console.WriteLine($"У числа {number} нет третьей цифры");
    }
    else
    {
        if (number < 0)
        {
            Console.WriteLine($"Третья цифра числа {number} - {num1[3]}");
        }
        else
        {
            Console.WriteLine($"Третья цифра числа {number} - {num1[2]}");
        }
    }
    
}


void Weekend(string dayNum)
{
    int checkNum;
    int.TryParse(dayNum, out checkNum);
    while (checkNum < 1 || checkNum > 7)
    {
        Console.WriteLine("Ошибка! Введите номер дня от 1 до 7: ");
        dayNum = Console.ReadLine()?? "0";
        int.TryParse(dayNum, out checkNum);
    }

    if (checkNum == 6 || checkNum == 7)
    {
        Console.WriteLine($"День номер {checkNum} является выходным.");
    }
    else
    {
        Console.WriteLine($"День номер {checkNum} не является выходным.");
    }
}


Console.WriteLine("Задача 10");
Console.WriteLine("Введите число от 100 до 999: ");
string num = Console.ReadLine() ?? "0";
FindMiddle(num);

Console.WriteLine("Задача 13");
Console.WriteLine("Введите число не равное нулю: ");
string num1 = Console.ReadLine() ?? "0";
FindThird(num1);

Console.WriteLine("Задача 15");
Console.WriteLine("Введите номер дня от 1 до 7: ");
string day = Console.ReadLine() ?? "0";
Weekend(day);