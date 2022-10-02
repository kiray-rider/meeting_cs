// Задача 3: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{System.Console.WriteLine($"Число {number} является четным");}
if (number%2 != 0)
{System.Console.WriteLine($"Число {number} является нечетным");}