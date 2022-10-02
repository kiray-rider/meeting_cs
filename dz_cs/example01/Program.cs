// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{System.Console.WriteLine($"Число A({numberA}) больше числа B({numberB})");}
if (numberA<numberB)
{System.Console.WriteLine($"Число A({numberA}) меньше числа B({numberB})");}
if (numberA==numberB)
{System.Console.WriteLine($"Число A({numberA}) равно числу B({numberB})");}