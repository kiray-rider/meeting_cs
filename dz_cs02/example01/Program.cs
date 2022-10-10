// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 100 | number > 999)
{
    Console.WriteLine("Число не трехзначное");
    Console.Write("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int number2 = (number % 100 - number % 10) / 10;
Console.Write($"Вторая цифра трехзначного числа: {number2}");
