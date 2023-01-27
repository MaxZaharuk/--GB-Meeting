/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Сколько чисел? ");
int count = int.Parse(Console.ReadLine());
int countPositive = 0;

for (int i = 1; i <= count; i++)
{
    Console.WriteLine($"Введите {i}-е число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        countPositive += 1;
    }
}

Console.WriteLine($"Чисел больше нуля: {countPositive}");

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double [] GetArgs()
{
    Console.WriteLine("Введите через пробел аргументы (по порядку: b1, k1, b2, k2) функции: ");
    double [] args = (Console.ReadLine().Split(" ").Select(double.Parse).ToArray());
    return args;
}


double [] argsFunc = GetArgs();
double b1 = argsFunc[0];
double k1 = argsFunc[1];
double b2 = argsFunc[2];
double k2 = argsFunc[3];


// После преобразования формулы получим x = (b2 - b1) / (k1 - k2)

double x = (b2 - b1) / (k1 - k2);

Console.WriteLine($"Точка пересечения: ({x}; {k1 * x + b1})");
