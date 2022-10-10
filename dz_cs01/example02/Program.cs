// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три любых числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2 & number1>number3)
{System.Console.WriteLine($"Число {number1} - самое большое");}
if (number2>number1 & number2>number3)
{System.Console.WriteLine($"Число {number2} - самое большое");}
if (number3>number2 & number3>number1)
{System.Console.WriteLine($"Число {number3} - самое большое");}