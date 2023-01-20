/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetNumbers(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            return result;
        }
        Console.WriteLine("Введите корректное положительное число");
    }
}

int number1 = GetNumbers("Введите первое положительное число:");
int number2 = GetNumbers("Введите первое положительное число:");

Console.WriteLine($"{number1} в степени {number2} равно {Math.Pow(number1, number2)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number)
{
    string number_str = number.ToString();
    int summ = 0;
    foreach (char num in number_str)
    {
        summ = summ + int.Parse(num.ToString());
    }
    return summ;
}


int number3 = GetNumbers("Введите положительное число:");
Console.WriteLine($"Сумма цифр числа {number3} равна {GetSum(number3)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// все 8 элементов должны получить за один Console.ReadLine();
// подсказка: использовать потом метод string.Split();

Console.WriteLine("Введите числа через запятую:");
string[] str = Console.ReadLine().Split(",");
foreach (string num in str)
{
    Console.Write(num);
}