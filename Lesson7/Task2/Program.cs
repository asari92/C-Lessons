// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] bivariateArray = GetRandomBivariateArray(5, 6);
ShowBivariateArray(bivariateArray);
int rowNumber = Prompt("Введите номер строки: ");
int columnNumber = Prompt("Введите номер столбца: ");
if (CheckRecuiredValue(bivariateArray, rowNumber, columnNumber))
{
    System.Console.WriteLine(bivariateArray[rowNumber, columnNumber]);
}

bool CheckRecuiredValue(int[,] bivariateArray, int rowNumber, int columnNumber)
{
    bool isValidValue;
    try
    {
        int checkValue = bivariateArray[rowNumber, columnNumber];
        isValidValue = true;
    }
    catch
    {
        Console.WriteLine("Запрашиваемого элемента не существует!");
        isValidValue = false;
    }
    return isValidValue;
}

void ShowBivariateArray(int[,] bivariateArray)
{
    int rows = bivariateArray.GetUpperBound(0) + 1;
    int columns = bivariateArray.Length / rows;

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