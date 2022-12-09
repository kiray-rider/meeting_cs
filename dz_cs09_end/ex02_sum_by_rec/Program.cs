// Задача 2: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int m = InputValue("\nКомпьютер выдаст сумму натуральных чисел от M до N \nВведите М: ");
int n = InputValue("Введите N: ");
NaturalSumChekAndDraw(m, n);


int InputValue(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void NaturalSumChekAndDraw(int numBegin, int numEnd)
{
    if (numBegin > numEnd) Console.WriteLine("Так не пойдет! M больше N!");
    else if (numBegin < 0 & numEnd < 0) Console.WriteLine("Так не пойдет! M и N отрицательные!");
    else if (numBegin < 0 & numEnd > 0)
    {
        Console.Write($"\nM = {numBegin}; N = {numEnd} -> ");
        Console.WriteLine(NaturalSumBetween(0, numEnd));
    }
    else
    {
        Console.Write($"\nM = {numBegin}; N = {numEnd} -> ");
        Console.WriteLine(NaturalSumBetween(numBegin, numEnd));
    }
}

int NaturalSumBetween(int numBegin, int numEnd, int sum = 0)
{
    sum += numBegin;
    numBegin++;
    if (numBegin <= numEnd) return NaturalSumBetween(numBegin, numEnd, sum);
    else return sum;
}