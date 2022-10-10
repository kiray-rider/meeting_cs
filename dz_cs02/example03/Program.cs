// Задача 3: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numWithoutEnd = number;
int num3 = 0;
while (numWithoutEnd > 999)
{
    numWithoutEnd = (numWithoutEnd - numWithoutEnd % 10) / 10;
}
if (number < 100)
{
    Console.WriteLine("У числа нет третьей цифры");
}
if (numWithoutEnd >= 100)
{
    num3 = numWithoutEnd % 10;
    Console.WriteLine($"Третья цифра числа: {num3}");
}
