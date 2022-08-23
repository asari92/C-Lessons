// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetRandomArray(8);
ShowArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {GetSumOfUnevenElements(array)}");

int GetSumOfUnevenElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length ; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

void ShowArray(int[] array)
{
    Console.WriteLine("{0}", string.Join(", ", array));
}

int[] GetRandomArray(int arraySize)
{
    int[] randomArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        randomArray[i] = new Random().Next(-100, 100);
    }
    return randomArray;
}