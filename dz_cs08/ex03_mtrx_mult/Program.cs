// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.

Console.WriteLine("\nКомпьютер задаст ДВЕ матрицы m x n, из случайных чисел. Затем умножит ПЕРВУЮ на ВТОРУЮ. \nПервая:");
int m1 = InputValue("Число СТРОК первой (m): ");
int n1 = InputValue("Число СТОЛБЦОВ первой (n): ");
int min1 = InputValue("МИНИМальный размер значения ПЕРВОЙ матрицы: ");
int max1 = InputValue("МАКСимальный размер значения ПЕРВОЙ матрицы: ") + 1;
Console.WriteLine("\nЧтобы можно было умножить две матрицы, количество столбцов \nПЕРВОЙ матрицы должно быть равно количеству строк ВТОРОЙ.");
int m2 = n1;
Console.WriteLine($"В итоге Число СТРОК второй (m): {m2}");
int n2 = InputValue("Число СТОЛБЦОВ второй (n): ");
int min2 = InputValue("МИНИМальный размер значения ВТОРОЙ матрицы: ");
int max2 = InputValue("МАКСимальный размер значения ВТОРОЙ матрицы: ") + 1;
int[,] matrixA = CreateMatrix(m1, n1, min1, max1);
int[,] matrixB = CreateMatrix(m2, n2, min2, max2);
Console.WriteLine("\nПервая матрица:");
PrintMatrix(matrixA);
Console.WriteLine("\nВторая матрица:");
PrintMatrix(matrixB);
Console.WriteLine("\nРезультат умножения:");
int[,] matrixMult = MatrixMult(matrixA, matrixB);
PrintMatrix(matrixMult);

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

int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixResult = new int[matrixB.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixResult[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixResult;
}
