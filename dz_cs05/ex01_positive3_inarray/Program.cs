// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Компьютер создаст массив из случайных 3-х значных элементов.");
int length = InputNumber("введите ДЛИНУ массива: ");
int randomStart = 100; //InputNumber("введите МИНИМальное значение одного элемента: ");
int randomLimit = 1000; //InputNumber("введите МАКСимальное значение одного элемента: ");
Console.WriteLine("Итоговый массив:");
int[] arr = FillArray(length, randomStart, randomLimit);
PrintArray(arr);
Console.WriteLine();
PositiveCount(arr);

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
        int r = new Random().Next(randomStart, randomLimit); // если убрать все из скобок в Next - ограничением будет макс. размер 32бит. числа
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

void PositiveCount(int[] arr)
{
    int positiveCount = 0;
    for (int i = 0; i <= (arr.Length - 1); i++)
    {
        if (arr[i] % 2 == 0) positiveCount++;
    }
    Console.Write("Колличество позитивных значений: ");
    Console.WriteLine(positiveCount);
}