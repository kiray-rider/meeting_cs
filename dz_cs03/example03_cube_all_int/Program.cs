// Задача 3. Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


///////////////////////////////////////////////// старое решение:
/* Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел, от 1 до N: ");
for (int number = 1; number <= numberN; number++) // для всех чисел от 1 до N, с прибавлением шага на +1, выполнять:
{
    Console.Write($"{Math.Pow(number,3)}, "); // возведение в куб
    if (number % 10 == 0) Console.WriteLine();   // с разбивкой по 10 чисел в строке
} */

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ShowCubes(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i * i * i} ");
        if (i % 10 == 0) Console.WriteLine(); // с разбивкой по 10 чисел в строке
    }
}

int n = Prompt("Введите число N: ");
Console.WriteLine("Таблица кубов чисел, от 1 до N: ");
ShowCubes(n);