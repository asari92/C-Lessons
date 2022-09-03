// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int numberOfRows = Prompt("Введите количество строк первой матрицы: ");
int numberOfColumns = Prompt("Введите количество столбцов первой матрицы: ");
int[,] bivariateArray1 = GetRandomBivariateArray(numberOfRows, numberOfColumns);
ShowBivariateArray(bivariateArray1);

numberOfRows = Prompt("Введите количество строк второй матрицы: ");
numberOfColumns = Prompt("Введите количество столбцов второй матрицы: ");
int[,] bivariateArray2 = GetRandomBivariateArray(numberOfRows, numberOfColumns);
ShowBivariateArray(bivariateArray2);

if (bivariateArray1.GetLength(1) == bivariateArray2.GetLength(0))
{
    Console.WriteLine("Произведение введенных матриц:");
    ShowBivariateArray(GetMatrixProduct(bivariateArray1, bivariateArray2));
}
else
{
    Console.Write("Введенные матрицы несовместимы!");
}

int[,] GetMatrixProduct(int[,] bivariateArray1, int[,] bivariateArray2)
{
    int rows = bivariateArray1.GetLength(0);
    int columns = bivariateArray2.GetLength(1);
    int[,] matrixProduct = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < bivariateArray2.GetLength(0); k++)
            {
                matrixProduct[i, j] += bivariateArray1[i, k] * bivariateArray2[k, j];
            }
        }
    }
    return matrixProduct;
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