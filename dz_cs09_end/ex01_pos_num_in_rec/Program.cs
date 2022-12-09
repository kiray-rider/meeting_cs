// Задача 1: Задайте значения M и N. Напишите программу, которая
// выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int m = InputValue("\nКомпьютер выдаст все четные натуральные числа от M до N \nВведите М: ");
int n = InputValue("Введите N: ");
NaturalNumChekAndDraw(m, n);


int InputValue(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void NaturalNumChekAndDraw(int numBegin, int numEnd)
{
    if (numBegin > numEnd) Console.WriteLine("Так не пойдет! M больше N!");
    else if (numBegin < 0 & numEnd < 0) Console.WriteLine("Так не пойдет! M и N отрицательные!");
    else if (numBegin == numEnd | numEnd - numBegin < 2) Console.WriteLine("Между M и N нет натуральных чисел :(");
    else if (numBegin < 0 & numEnd > 0)
    {
        Console.Write($"\nM = {numBegin}; N = {numEnd} -> ");
        NaturalNumBetween(0, numEnd);
    }
    else
    {
        Console.Write($"\nM = {numBegin}; N = {numEnd} -> ");
        NaturalNumBetween(numBegin, numEnd);
    }
}

void NaturalNumBetween(int numBegin, int numEnd)
{
    if (numBegin % 2 == 0)
    {
        if (numBegin > numEnd) return;
        else if (numBegin == numEnd || numEnd - numBegin < 2)
        {
            Console.WriteLine($"{numBegin}."); //здесь мне просто захотелось точку в конце
            return;
        }
        Console.Write($"{numBegin}, ");
        numBegin = numBegin + 2;
    }
    else if (numBegin % 2 != 0)
    {
        numBegin = numBegin + 1;
        if (numEnd - numBegin < 2)
        {
            Console.WriteLine($"{numBegin}.");
            return;
        }
        Console.Write($"{numBegin}, ");
        numBegin = numBegin + 2;
    }
    NaturalNumBetween(numBegin, numEnd);
}
