// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetNumber(string message)
{
    Console.WriteLine(message);
    while (true)
    {
        int result;
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        Console.WriteLine("Введите корректный размер массива:");
    }
}

int[] CreateArray(int elementsQuantity, int task)
{
    Random randomNumber = new Random();
    int[] array = new int[elementsQuantity];
    for (int i = 0; i < array.Length; i++)
    {
        if (task == 34)
        {
            array[i] = randomNumber.Next(100, 999);
        }
        if (task == 36)
        {
            array[i] = randomNumber.Next(-100, 100);
        }
    }
    return array;
}

double[] CreateDoubleArray(int elementsQuantity, int task)
{
    Random randomNumber = new Random();
    double[] array = new double[elementsQuantity];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.NextDouble() * 10;

    }
    return array;
}

int FindEvens(int[] array)
{
    int countEvens = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            countEvens += 1;
        }
    }
    return countEvens;
}

string PrintArray(int[] arr)
{
    string str = String.Empty;
    foreach (int number in arr)
    {
        str = str + number.ToString() + " ";
    }
    return str;
}


int task = 34;
int size = GetNumber("Введите размер массива");
int[] array = CreateArray(size, task);
Console.WriteLine($"Количество четных чисел в массиве ({PrintArray(array)}) : {FindEvens(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumOddsIndex(int[] array)
{
int sumOdds = 0;
    for (int i = 1; i <= array.Length - 2; i = i + 2)
    {
        sumOdds += array[i];
    }
    return sumOdds;
}

task = 36;
size = GetNumber("Введите размер массива");
array = CreateArray(size, task);
Console.WriteLine($"Сумма всех элементов массива {PrintArray(array)} c нечетным индексом: {GetSumOddsIndex(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

task = 38;
size = GetNumber("Введите размер массива");
double[] arr = CreateDoubleArray(size, task);
Console.WriteLine($"Разница максимального и минимального элементов массива {PrintArray(array)} : {array.Max() - array.Min()}");



