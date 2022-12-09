// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

Console.WriteLine("\nКомпьютер задаст матрицу размером m x n, из случайных целых чисел. \nЗатем найдет строку с наименьшей суммой элементов.");
int m = InputValue("Введите число СТРОК (m): ");
int n = InputValue("Введите число СТОЛБЦОВ (n): ");
int min = InputValue("Введите МИНИМальный размер значения: ");
int max = InputValue("Введите МАКСимальный размер значения: ") + 1;
int[,] matrix = CreateMatrix(m, n, min, max);
PrintMatrix(matrix);
Console.WriteLine();
int minLine = SmallestLineInMtrx(matrix);
Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minLine + 1}");

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

int SmallestLineInMtrx(int[,] matrix)
{
    int[] sumLines = new int[matrix.GetLength(0)];  //создаю массив сумм всех строк матрицы
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sumLines[j] += matrix[j, i];
        }
    }
    int min = sumLines[0];   //ищу минимальную строку
    int minLine = 0;
    for (int k = 1; k < sumLines.Length; k++)
    {
        if (sumLines[k] < min)
        {
            min = sumLines[k];
            minLine = k;
        }
    }
    return minLine;
}
