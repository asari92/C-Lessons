// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int numberOfRows = Prompt("Введите количество строк: ");
int numberOfColumns = Prompt("Введите количество столбцов: ");
int[,] bivariateArray = GetRandomBivariateArray(numberOfRows, numberOfColumns);
ShowBivariateArray(bivariateArray);
Console.WriteLine("Отсортированный массив:");
SortBivariateArrayOnDecreasing(bivariateArray);
ShowBivariateArray(bivariateArray);

void SortBivariateArrayOnDecreasing(int[,] bivariateArray)
{
    int rows = bivariateArray.GetLength(0);
    int columns = bivariateArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int[] row = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            row[j] = bivariateArray[i, j];
        }
        SortArrayOnDecreasing(row);
        for (int j = 0; j < columns; j++)
        {
            bivariateArray[i, j] = row[j];
        }
    }
}

void SortArrayOnDecreasing(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
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
            bivariateArray[i, j] = new Random().Next(10, 100);
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