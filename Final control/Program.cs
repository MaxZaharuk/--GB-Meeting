int GetNumber(string message)
{
    Console.WriteLine(message);
    int result;
    int.TryParse(Console.ReadLine(), out result);
    return result;
}

string[] CreateArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива:");
        arr[i] += Console.ReadLine();
    }
    return arr;
}

string GetResult(string[] arr)
{
    string result = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result += arr[i] + " ";
        }
    }
    return result;
}

int arraySize = GetNumber("Введите размер массива:");
string[] arr = CreateArray(arraySize);
string result = GetResult(arr);
string[] finalResult = result.Split("");
/* если нужна печать, то раскомментировать следующий кусок кода.
foreach (string item in finalResult)
{
    Console.WriteLine(item);
}
*/
