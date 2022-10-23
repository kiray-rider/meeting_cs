// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Компьютер создаст массив из случайных элементов.");
int length = InputNumber("введите ДЛИНУ массива: ");
int randomStart = InputNumber("введите МИНИМальное значение одного элемента: ");
int randomLimit = InputNumber("введите МАКСимальное значение одного элемента: ");
Console.WriteLine("Итоговый массив:");
int[] arr = FillArray(length, randomStart, randomLimit);
PrintArray(arr);
Console.WriteLine();
NegatIndexSum(arr);

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

void NegatIndexSum(int[] arr)
{
    int negatSum = 0;
    for (int i = 0; i <= (arr.Length - 1); i++)
    {
        if (i % 2 != 0) negatSum = negatSum + arr[i];
    }
    Console.Write("Сумма значений под нечетными индексами: ");
    Console.WriteLine(negatSum);
}