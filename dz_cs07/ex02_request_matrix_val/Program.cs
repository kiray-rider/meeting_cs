// Задача 2. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Компьютер задаст матрицу размером m x n, из случайных целых чисел:");
int m = InputValue("Введите число СТРОК (m): ");
int n = InputValue("Введите число СТОЛБЦОВ (n): ");
int min = InputValue("Введите МИНИМальный размер значения: ");
int max = InputValue("Введите МАКСимальный размер значения: ") + 1;
int[,] matrix = CreateMatrix(m, n, min, max);
PrintMatrix(matrix);
Console.WriteLine("Компьютер любезно отобразит для Вас значение заданной позиции в матрице:");
int mRequest = InputValue("Введите СТРОКУ (m): ");
int nRequest = InputValue("Введите СТОЛБЕЦ (n): ");
int matrixValue = RequestMatrixValue(matrix, mRequest, nRequest);
Console.WriteLine($"Запрошенное значение: {matrixValue}.");

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

int RequestMatrixValue(int[,] matrix, int mRequest, int nRequest)
{
    while (mRequest > matrix.GetLength(0) || mRequest < 1 ||
            nRequest > matrix.GetLength(1) || nRequest < 1)
    {
        Console.WriteLine("Такой позиции в матрице нет!");
        mRequest = InputValue("Введите корректую СТРОКУ (m): ");
        nRequest = InputValue("Введите корректный СТОЛБЕЦ (n): ");
    }
    int matrixValue = matrix[mRequest - 1, nRequest - 1];
    return matrixValue;
}
