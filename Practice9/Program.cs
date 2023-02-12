// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Task 64");

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = 0;
    int.TryParse(Console.ReadLine(), out number);
    return number;
}

int naturalRow(int N)
{
    if (N == 1) return 1;
    Console.WriteLine(N - 1);
    return naturalRow(N - 1);
}

naturalRow(GetNumber("Введите число N:"));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Task 66");

int naturalRowSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + naturalRowSum(m, n - 1);
}

int M = GetNumber("Введите число M");
int N = GetNumber("Введите число N");
if (M > N)
{
    int temp = N;
    N = M;
    M = temp;
}

Console.WriteLine(naturalRowSum(M, N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Task 68");

int Ackerman(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    } 
    else if (m > 0 && n == 0) 
    {
        return Ackerman(m - 1, 1);
    } 
    else if (m > 0 && n > 0) 
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    } 
    else 
    {
        return 0;
    }
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

int result = Ackerman(m, n);

Console.WriteLine($"Ackerman({m}, {n}) = {result}");
