// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumber(string message)
{   int result;
    Console.WriteLine(message);
    result = int.Parse(Console.ReadLine());
    return result;
}

double [,] CreateArray(int rows, int columns)
{
    double [,] arr = new double [rows, columns];
    Random rnd = new Random();
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            arr[row, column] = Math.Round(rnd.NextDouble() * 10.0, 2);
        }
    }
    return arr;
}

void PrintArray(double [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
double [,] arr = CreateArray(rows, columns);
PrintArray(arr);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Так как в задаче не указано, какие должны быть значения в массиве, будем использовать вещественные положительные числа из предыдущей, а значит и весь код.
//Другими словами, просто добавим метод, который напрямую решает задачу.

bool CheckElement(double [,] array, int row, int column)
{
    return (array.GetLength(0) - 1 >= row && array.GetLength(1) - 1 >= column);
}

int rowIndex = GetNumber("Введите индекс строки");
int columnIndex = GetNumber("Введите индекс столбца");

if (CheckElement(arr, rowIndex, columnIndex))
{
    Console.WriteLine(arr[rowIndex, columnIndex]);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreateIntArray(int rows, int columns)
{
    int [,] arr = new int [rows, columns];
    Random rnd = new Random();
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            arr[row, column] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintIntArray(int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

void FindMean(int [,] array)
{
    double [] arr = new double [array.GetLength(1)];
    Console.WriteLine("Арифметическое среднее столбцов:");
    for (int column = 0; column < array.GetLength(0); column++)
    {
        double summ = 0;
        for (int row = 0; row < array.GetLength(1); row++)
        {
            summ += array[row, column];
        }
        double element = summ / (array.GetLength(0));
        arr[column] = element;
        Console.Write(arr[column] + " ");
    }
}

int rowsNew = GetNumber("Введите количество строк");
int columnsNew = GetNumber("Введите количество столбцов");
int [,] arrInt = CreateIntArray(rows, columns);
PrintIntArray(arrInt);
FindMean(arrInt);
