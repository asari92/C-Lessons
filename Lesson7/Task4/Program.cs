// Задача 4. Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

int numberOfRows = Prompt("Введите количество строк: ");
int numberOfColumns = Prompt("Введите количество столбцов: ");
int[,] bivariateArray = GetRandomBivariateArray(numberOfRows, numberOfColumns);
ShowBivariateArray(bivariateArray);
int rowsSumOfMaxs = GetRowsSumOfMaxs(bivariateArray);
int columnsSumOfMins = GetColumnsSumOfMins(bivariateArray);
System.Console.WriteLine($"Сумма максимальных значений строк: {rowsSumOfMaxs}");
System.Console.WriteLine($"Сумма минимальных значений столбцов: {columnsSumOfMins}");
System.Console.WriteLine($"Разность сумм: {rowsSumOfMaxs - columnsSumOfMins}");

int GetArraySum(int[] array)
{
    int arraySum = 0;
    foreach (var item in array)
    {
        arraySum += item;
    }
    return arraySum;
}

int GetArrayMin(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int GetArrayMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int GetRowsSumOfMaxs(int[,] bivariateArray)
{
    int rows = bivariateArray.GetLength(0);
    int columns = bivariateArray.GetLength(1);
    int[] rowsMaxs = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        int[] row = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            row[j] = bivariateArray[i, j];
        }
        rowsMaxs[i] = GetArrayMax(row);
    }
    return GetArraySum(rowsMaxs);
}

int GetColumnsSumOfMins(int[,] bivariateArray)
{
    int rows = bivariateArray.GetLength(0);
    int columns = bivariateArray.GetLength(1);
    int[] columnsMins = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        int[] column = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            column[i] = bivariateArray[i, j];
        }
        columnsMins[j] = GetArrayMin(column);
    }
    return GetArraySum(columnsMins);
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