// Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

int[] array = GetRandomArray(8);
ShowArray(array);
System.Console.WriteLine($"Второй максимальный элемент = {GetSecondMax(array)}");

int GetSecondMax(int[] array)
{
    int max = array[0], secondMax = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > secondMax)
        {
            secondMax = array[i];
        }
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
    }

    return secondMax;
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
        randomArray[i] = new Random().Next(0, 100);
    }
    return randomArray;
}