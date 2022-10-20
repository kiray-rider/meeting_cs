// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (и в нулевую степень). 
// Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numA = InputNumber("Введите число A: ");
int numB = InputNumber("Введите число B: ");
int resultExp = ExpIt(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} будет равно = {resultExp}");

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ExpIt(int numA, int numB)
{
    int exp = 1;
    for(int i = 1; i <= numB; i++)
    {
        exp = exp * numA;
    }
    return exp;
}
