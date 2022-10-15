// Задача 1. Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. Не применять строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите пятизначное число: ");

while (number > 99999 | number < 10000)
{
    System.Console.WriteLine("Это число НЕ пятизначное!");
    number = Prompt("Введите пятизначное число: ");
}

int[] array = new int[5];         // новый массив длинной в 5, заполненный нулями
int numberWithoutEnd = number;
int index = array.Length - 1;

while (numberWithoutEnd > 0)
{
    array[index] = numberWithoutEnd % 10;
    numberWithoutEnd = (numberWithoutEnd - numberWithoutEnd % 10) / 10;
    index--;
    if (index < 0) break;
}

if (array[4] == array[0] & array[3] == array[1])
{
    System.Console.WriteLine($"Число {number} является палиндромом!");
}
else
{
    System.Console.WriteLine($"Число {number} НЕ является палиндромом!");
}
