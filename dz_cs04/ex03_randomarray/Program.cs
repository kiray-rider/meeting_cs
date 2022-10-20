// Задача 3: Напишите программу, которая задаёт массив из 8 случайных 
// элементов и выводит их на экран. Сделать через функции.
// 1, 2, 5, 7, 19, 6, 7, 8

Console.WriteLine("Компьютер создаст массив из 8 случайных элементов.");
int randomStart = InputNumber("введите минимальное значение одного элемента: ");
int randomLimit = InputNumber("введите максимальное значение одного элемента: ");
Console.WriteLine("Итоговый массив:");
PrintArray(FillArray(8, randomStart, randomLimit));
Console.WriteLine();

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