// Задача 2: Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.Write("Компьютер выбрал случайное трехзначное число: ");
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine(randomNumber);
int num13 = ((randomNumber - randomNumber % 100) / 10) + randomNumber % 10;
Console.Write("Число без второй цифры: ");
Console.WriteLine(num13);
