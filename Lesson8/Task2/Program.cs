// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int numberOfRows = Prompt("Введите количество строк: ");
int numberOfColumns = Prompt("Введите количество столбцов: ");
int[,] bivariateArray = GetRandomBivariateArray(numberOfRows, numberOfColumns);
ShowBivariateArray(bivariateArray);
int rowWithSmallestSum = 1 + GetArrayMinAndIndex(GetRowSums(bivariateArray)).minIdex;
Console.Write($"Номер строки с наименьшей суммой элементов: {rowWithSmallestSum}");

int[] GetRowSums(int[,] bivariateArray)
{
    int rows = bivariateArray.GetLength(0);
    int columns = bivariateArray.GetLength(1);
    int[] rowSums = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        int[] row = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            row[j] = bivariateArray[i, j];
        }
        rowSums[i] = GetArraySum(row);
    }
    return rowSums;
}

(int min, int minIdex) GetArrayMinAndIndex(int[] array)
{
    int min = array[0];
    int minIdex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIdex = i;
        }
    }
    return (min, minIdex);
}

int GetArraySum(int[] array)
{
    int arraySum = 0;
    foreach (var item in array)
    {
        arraySum += item;
    }
    return arraySum;
}

void ShowBivariateArray(int[,] bivariateArray)
{
    int rows = bivariateArray.GetLength(0);
    int columns = bivariateArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{bivariateArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] GetRandomBivariateArray(int rows, int columns)
{
    int[,] bivariateArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            bivariateArray[i, j] = new Random().Next(1, 10);
        }
    }
    return bivariateArray;
}

int Prompt(string message)
{
    System.Console.Write(message);
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Неверный ввод! Повторите попытку.");
        System.Console.Write(message);
    }
    return number;
}