// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите день недели цифрой: ");
int weekDayNumber = Convert.ToInt32(Console.ReadLine());
while (weekDayNumber > 7 | weekDayNumber < 1)
{
    Console.WriteLine("Введенное число не является цифрой дня недели");
    Console.Write("Введите день недели цифрой: ");
    weekDayNumber = Convert.ToInt32(Console.ReadLine());
}
if (weekDayNumber < 6)
{
    Console.WriteLine($"Введенное число {weekDayNumber}, не является выходным днём недели");
}
else
{
    Console.WriteLine($"Введенное число {weekDayNumber}, является выходным днём недели");
}
