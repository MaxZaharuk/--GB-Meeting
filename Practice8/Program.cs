/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Task 54");

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = 0;
    int.TryParse(Console.ReadLine(), out number);
    return number;
}

int [,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    int [,] arr = new int[rows, columns];
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            arr[row,column] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void SortRowsByDecrease(int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            int maxValue = array[row, column];
            int [] indexes = {row, column};
            for (int i = column + 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] > array[row, column])
                {
                    maxValue = array[row, i];
                    indexes[1] = i;
                    int temp = array[row, column];
                    array[row, column] = maxValue;
                    array[indexes[0], indexes[1]] = temp;
                }
            }

        }
    }
}

void PrintArray(int [,] array)
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


int row = GetNumber("Введите количество строк");
int column = GetNumber("Введите количество столбцов");
int [,] array = CreateArray(row, column);
PrintArray(array);
SortRowsByDecrease(array);
Console.WriteLine();
PrintArray(array);

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

//!Не вижу препятствий для того, чтобы использовать массив, который получился в предыдущей задаче, чтобы не писать лишний код!

Console.WriteLine("Task 56");

int GetMinRowsSum(int [,] array)
{
    int minSum = 0;
    int rowMin = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int rowSum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            rowSum += array[row, column];
        }
        if (minSum == 0)
        {
            minSum = rowSum;
            rowMin = 1;
        }
        if (minSum > rowSum)
        {
            minSum = rowSum;
            rowMin = row + 1;
        }
    }
    return rowMin;    
}

Console.WriteLine($"Минимальная сумма элементов в {GetMinRowsSum(array)}ой строке");

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Task 58");

int [,] TransposeMatrix(int [,] array)
{
    int [,] result = new int [array.GetLength(1), array.GetLength(0)];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            result[column, row] = array[row, column];
        }
    }
    return result;
}

int[,] GetMultiply(int [,] array1, int [,] array2)
{
    array1 = TransposeMatrix(array1);
    int [,] result = new int [array2.GetLength(0), array2.GetLength(1)];
    for (int iFirstColumn = 0; iFirstColumn < array1.GetLength(1); iFirstColumn++)
    {
        for (int iSecondColumn = 0; iSecondColumn < array2.GetLength(1); iSecondColumn++)
        {
            int sumOfMultiplied = 0;
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                sumOfMultiplied += (array1[j, iFirstColumn] * array2[j, iSecondColumn]);
            }
            result[iFirstColumn, iSecondColumn] = sumOfMultiplied;
        }
    }
    return result;
}

int m1Rows = GetNumber("Задайте количество строк в первой матрице:");
int m1Columns = GetNumber("Задайте количество столбцов в первой матрице:");
int m2Rows = GetNumber("Задайте количество строк во второй матрице:");
int m2Columns = GetNumber("Задайте количество столбцов во второй матрице:");
int [,] matrix1 = CreateArray(m1Rows, m1Columns);
int [,] matrix2 = CreateArray(m2Rows, m2Columns);

Console.WriteLine("Получены матрицы:");
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

if (m1Columns != m2Rows)
{
    Console.WriteLine("Такие матрицы умножить нельзя.");
}
else
{
    Console.WriteLine("Транспонированная первая матрица:");
    PrintArray(TransposeMatrix(matrix1));
    Console.WriteLine("Результат умножения:");
    int [,] multipliedMatrix = GetMultiply(matrix1, matrix2);
    PrintArray(multipliedMatrix);
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Task 60");

int [,,] CreateTripleArray(int rows, int columns, int depth)
{
    int [,,] result = new int [rows, columns, depth];
    Random rnd = new Random();
    int [] values = new int [row * column * depth];
    int countIndexValues = 0;
    for (int iDepth = 0; iDepth < depth; iDepth++)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                int value = rnd.Next(1, 100);
                while (values.Contains(value))
                {
                    value = rnd.Next(1, 100);
                }
                result[row, column, iDepth] = value;
                values[countIndexValues] = value;
                countIndexValues++;
            }
        }
    }
    return result;
}

void PrintTripleArray(int [,,] array)
{
    for (int iDepth = 0; iDepth < array.GetLength(2); iDepth++)
    {
        for (int row = 0; row < array.GetLength(1); row++)
        {
            for (int column = 0; column < array.GetLength(0); column++)
            {
                Console.Write($"{array[row, column, iDepth]}({row}, {column}, {iDepth}) ");
            }
            Console.WriteLine();
        }
    }
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int depth = GetNumber("Введите глубину массива:");

int [,,] arrTriple = CreateTripleArray(rows, columns, depth);
PrintTripleArray(arrTriple);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Task 62");

rows = GetNumber("Введите количество строк:");
columns = GetNumber("Введите количество столбцов:");


int count = 1;

string MakeElement(int count)
{
    string result = String.Empty;
    if (count < 10)
    {
        result = "0" + count.ToString();
    }
    else
    {
        result = count.ToString();
    }
    return result;
}


string [,] arraySp = new string [rows, columns];

int startRow = 0;
int startColumn = 0;
int finishRow = arraySp.GetLength(0);
int finishColumn = arraySp.GetLength(1);
bool reverse = false;
int add = -1;

while (count <= rows * columns)
{
    for (int iColumn = startColumn;;)
    {     
        arraySp[startRow, iColumn] = MakeElement(count);
        Console.WriteLine($"{arraySp[startRow, iColumn]}({startRow}, {iColumn})");   
        count++;
        iColumn -= add;
        if (iColumn  == finishColumn)
        {
            finishColumn = startColumn + add;
            startColumn = iColumn + add;
            startRow -= add;
            break;
        }
        
    }
    if (count >= rows * columns)
    {
        break;
    }
    for (int iRow = startRow;;)
    {
        arraySp[iRow, startColumn] = MakeElement(count);
        Console.WriteLine($"{arraySp[iRow, startColumn]}({iRow}, {startColumn})");
        count++;
        iRow -= add;
        if (iRow  == finishRow)
        {
            finishRow = startRow + add;
            startRow = iRow + add;
            startColumn += add;
            break;
        }
    }
    if (reverse)
    {
        reverse = false;
    } 
    else 
    {
        reverse = true;
    }
    add = -add;
}

void PrintStringArray(string [,] array)
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

PrintStringArray(arraySp);
