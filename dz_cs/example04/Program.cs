// Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberN < 0)
{
    int number1 = Convert.ToInt32(0);
    Console.WriteLine("Все четные числа между 1 и N: ");
    while(number1!=numberN)
        {
        Console.Write($" {number1}");
        number1 = number1 - 2;
        }
}

if(numberN > 0)
{
    int number1 = Convert.ToInt32(2);
    Console.WriteLine("Все четные числа между 1 и N: ");
    while(number1!=numberN)
        {
        Console.Write($" {number1}");
        number1 = number1 + 2;
        }
}