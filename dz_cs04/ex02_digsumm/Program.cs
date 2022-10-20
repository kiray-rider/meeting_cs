// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Функция должна на вход принимать 
// число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = InputNumber("Введите число: ");
int dSum = DigSumm(num);
Console.WriteLine($"Сумма цифр этого числа равна = {dSum}");

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int DigSumm(int num)
{
    int dSum = 0;
    while(num > 0)
    {
    dSum = num % 10 + dSum;
    num = (num - num % 10) / 10;
    }
    return dSum;
}
