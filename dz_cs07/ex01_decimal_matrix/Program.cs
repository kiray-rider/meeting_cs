// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Компьютер задаст матрицу размером m x n, из случайных вещественных чисел:");
int m = InputValue("Введите число СТРОК (m): ");
int n = InputValue("Введите число СТОЛБЦОВ (n): ");
int min = InputValue("Введите МИНИМальный размер значения: ");
int max = InputValue("Введите МАКСимальный размер значения: ") + 1;
decimal[,] matrix = CreateDeciMatrix(m, n, min, max);
PrintMatrix(matrix);

int InputValue(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

decimal RandomDeciPart(int maxRandom = 100) // флаг в 100 - 2 знака после запятой, в 10 - 1 знак после
{
    int randomNotDecimal = new Random().Next(1, maxRandom);
    decimal randomDecimal = Convert.ToDecimal(randomNotDecimal) / Convert.ToDecimal(maxRandom);
    return randomDecimal;
}

decimal[,] CreateDeciMatrix(int m, int n, int min, int max)
{
    decimal[,] matrix = new decimal[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)  // заполняем матрицу целыми числами
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDecimal(new Random().Next(min, max));
        }
    }
    for (int i = 0; i < matrix.GetLength(0) - (matrix.GetLength(0) / 3); i++) // плюсуем к части целых, десятичную часть
    {
        for (int j = 0; j < matrix.GetLength(1) - (matrix.GetLength(1) / 3); j++)
        {
            matrix[new Random().Next(0, matrix.GetLength(0)),
                    new Random().Next(0, matrix.GetLength(1))] += RandomDeciPart();
        }
    }
    return matrix;
}

void PrintMatrix(decimal[,] matrix)
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
