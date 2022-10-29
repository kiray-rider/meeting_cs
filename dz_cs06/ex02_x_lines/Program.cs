// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 

// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// decimal a = 2d/-4d;
// Console.WriteLine($"{a}");
Console.WriteLine("Компьютер найдет координату пересечения двух прямых, заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
decimal b1 = InputNumber("Введите b1: ");
decimal k1 = InputNumber("Введите k1: ");
decimal b2 = InputNumber("Введите b2: ");
decimal k2 = InputNumber("Введите k2: ");
decimal[] arr = LineCrossPoint(b1, k1, b2, k2);
Console.WriteLine($"Координаты пересечения прямых: x = {arr[0]}    y = {arr[1]}");

decimal InputNumber(string message)
{
    Console.Write(message);
    decimal number = Convert.ToInt32(Console.ReadLine());
    return number;
}

decimal[] LineCrossPoint(decimal b1, decimal k1, decimal b2, decimal k2)
{
    decimal x = (b2 - b1) / (k1 - k2);
    decimal y = k1 * x + b1;
    decimal[] arr = { x, y };
    return arr;
}