/*Урок 3. Базовые алгоритмы. Продолжение
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


string GetNumber(string message)
{
    int number;
    while (true){
        if ((!int.TryParse(message, out number)))
        {
            Console.WriteLine("Неверный ввод, введите число: ");
            message = Console.ReadLine() ?? "";
        }
        else if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Неверный ввод, введите пятизначное число: ");
            message = Console.ReadLine() ?? "";            
        }
        else
        {
            break;
        }
    }
    return number.ToString();
}


void IsPalindrome(string number)
{
    string newNumber = "";
    for (int i = 0; i < number.Length; i++)
    {
        newNumber = number[i] + newNumber;
    }
    if (number == newNumber)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}


int GetPointCoordinate(string message)
{
    int number;
    while (true){
        if ((!int.TryParse(message, out number)))
        {
            Console.WriteLine("Неверный ввод, введите число: ");
            message = Console.ReadLine() ?? "";
        }
        else
        {
            break;
        }
    }
    return number;
}


double FindDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + 
    Math.Pow(z2 - z1, 2));
    return Math.Round(distance, 2);
}


int GetNumberToPow(string message)
{
    int number;
    while (true){
        if ((!int.TryParse(message, out number)))
        {
            Console.WriteLine("Неверный ввод, введите число: ");
            message = Console.ReadLine() ?? "";
        }
        else if (number <= 1)
        {
            Console.WriteLine("Неверный ввод, число должно быть больше единицы: ");
            message = Console.ReadLine() ?? "";           
        }
        else
        {
            break;
        }
    }
    return number;
}


void MakeCubeList(int number)
{
    Console.Write($"Кубы числа {number}: ");
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}


Console.WriteLine("----------ЗАДАЧА 19----------");

Console.WriteLine("Введите пятизначное число: ");
string message = Console.ReadLine() ?? "";
IsPalindrome(GetNumber(message));

Console.WriteLine("----------ЗАДАЧА 21----------");

Console.WriteLine("Введите координату x для первой точки: ");
int x1 = GetPointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату y для первой точки: ");
int y1 = GetPointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату z для первой точки: ");
int z1 = GetPointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату x для второй точки: ");
int x2 = GetPointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату y для второй точки: ");
int y2 = GetPointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату z для второй точки: ");
int z2 = GetPointCoordinate(Console.ReadLine() ?? "");

Console.WriteLine($"Расстояние между точками равно {FindDistance(x1, x2, y1, y2, z1, z2)}");

Console.WriteLine("----------ЗАДАЧА 23----------");

Console.WriteLine("Введите число больше единицы: ");
int cubeLimit = GetNumberToPow(Console.ReadLine() ?? "");
MakeCubeList(cubeLimit);
