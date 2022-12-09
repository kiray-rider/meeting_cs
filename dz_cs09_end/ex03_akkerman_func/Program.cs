// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 1, n = 2 -> A(m,n) = 4
// m = 0, n = 1 -> A(m,n) = 2
// m = 0, n = 0 -> A(m,n) = 1
// m = 2, n = 2 -> A(m,n) = 7

Console.WriteLine("\nКомпьютер посчитает функцию Аккермана А(m,n). \nДаны два неотрицательных числа m и n");
int m = InputValue("Введите число m: ");
int n = InputValue("Введите число n: ");
AkkermanCheck(m, n);

int InputValue(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void AkkermanCheck(int m, int n)
{
if (m < 0 || n < 0) Console.WriteLine($"Так не пойдет! числа не должны быть отрицательными!");
else Console.WriteLine($"Результат функции: {Akkerman(m,n)}");
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
