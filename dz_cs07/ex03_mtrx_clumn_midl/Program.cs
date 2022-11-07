// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Компьютер задаст двумерный массив размером m x n, заполненный случайными целыми числами:");
int m = InputValue("Введите число СТРОК (m): ");
int n = InputValue("Введите число СТОЛБЦОВ (n): ");
int min = InputValue("Введите МИНИМальный размер значения: ");
int max = InputValue("Введите МАКСимальный размер значения: ") + 1;
int[,] matrix = CreateMatrix(m, n, min, max);
PrintMatrix(matrix);
decimal[] middleN = ColumnMiddle(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(middleN);

int InputValue(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

decimal ColumnSumm(int[,] matrix, int columnNumber)
{
    decimal summN = matrix[0, columnNumber];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        summN += matrix[i, columnNumber];
    }
    return summN;
}

decimal[] ColumnMiddle(int[,] matrix)
{
    decimal[] middleN = new decimal[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        middleN[j] = Convert.ToDecimal(ColumnSumm(matrix, j)) / Convert.ToDecimal(m);
    }
    return middleN;
}

void PrintArray(decimal[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] % 1 == 0) Console.Write($"{array[i]};\t");
        else Console.Write($"{array[i]:f2};\t");
    }
    if (array[array.Length - 1] % 1 == 0) Console.WriteLine($"{array[array.Length - 1]}.");
    else Console.WriteLine($"{array[array.Length - 1]:f2}.");
}
