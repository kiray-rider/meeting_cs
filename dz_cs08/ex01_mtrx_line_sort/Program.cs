// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки 
// двумерного массива.

Console.WriteLine("\nКомпьютер задаст матрицу размером m x n, из случайных целых чисел. \nЗатем отсортирует её.");
int m = InputValue("Введите число СТРОК (m): ");
int n = InputValue("Введите число СТОЛБЦОВ (n): ");
int min = InputValue("Введите МИНИМальный размер значения: ");
int max = InputValue("Введите МАКСимальный размер значения: ") + 1;
int[,] matrix = CreateMatrix(m, n, min, max);
PrintMatrix(matrix);
int[,] matrix2 = BubbleSort(matrix);
Console.WriteLine("\nОтсортированная матрица:");
PrintMatrix(matrix2);

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

int[,] BubbleSort(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int k = i + 1; k < matrix.GetLength(1); k++)
            {
                int temp = matrix[j, i];
                if (matrix[j, k] > matrix[j, i])
                {
                    matrix[j, i] = matrix[j, k];
                    matrix[j, k] = temp;
                }
            }
        }
    }
    return matrix;
}
