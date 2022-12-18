/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Выберите номер задания (2, 4, 6, 8): ");
int task = int.Parse(Console.ReadLine() ?? "0");

switch (task)
{
    case 2:
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        if (a == b)
        {
            Console.WriteLine("Числа равны.");
        }

        else if (a > b)
        {
            Console.WriteLine("Максимальное число: " + a);
        }

        else
        {
            Console.WriteLine("Максимальное число: " + b);
        }
    break;
    case 4:
        Console.Write("Введите первое число: ");
        int x = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите второе число: ");
        int y = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите третье число: ");
        int z = int.Parse(Console.ReadLine() ?? "0");

        if (x > y && x > z)
        {
            Console.WriteLine("Максимальное число: " + x);
        }
        else if (y > z)
        {
            Console.WriteLine("Максимальное число: " + y);
        }
        else
        {
            Console.WriteLine("Максимальное число: " + z);
        }
    break;
    case 6:
        Console.Write("Введите число: ");
        int even = int.Parse(Console.ReadLine() ?? "0");
        if (even % 2 != 0)
        {
            Console.WriteLine($"Число {even} нечетное");
        }
        else
        {
            Console.WriteLine($"Число {even} четное");
        }
        break;
    case 8:
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 2; i <= num; i += 2)
        {
            Console.Write(i + " ");
        }
    break;
    default:
        Console.WriteLine("Не было такого задания.");
    break;
}



