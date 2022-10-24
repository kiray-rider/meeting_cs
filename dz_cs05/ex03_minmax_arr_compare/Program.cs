// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Компьютер создаст массив из случайных элементов.");
int length = InputNumber("введите ДЛИНУ массива: ");
int randomStart = InputNumber("введите МИНИМальное значение одного элемента: ");
int randomLimit = InputNumber("введите МАКСимальное значение одного элемента: ");
Console.WriteLine("Итоговый массив:");
int[] arr = FillArray(length, randomStart, randomLimit);
PrintArray(arr);
Console.WriteLine();
MinMaxDiff(arr);

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FillArray(int length, int randomStart, int randomLimit)
{
    int[] array = new int[length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int r = new Random().Next(randomStart, randomLimit);
        array[i] = r;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void MinMaxDiff(int[] arr)
{
    int min = arr[0];
    int max = arr[1];
    int temp = 0;
    if (min > max)
    {
        temp = min;
        min = max;
        max = temp;
    }
    for (int i = 2; i <= (arr.Length - 1); i++)
    {

        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.Write("Разница максимального и минимального значений: ");
    Console.WriteLine(max - min);
}
