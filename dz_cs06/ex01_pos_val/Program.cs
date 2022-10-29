// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция 
// вводит данные, другая функция подсчитывает количество положительных)

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Какое колличество чисел (M) вы предпочитаете ввести?");
int length = InputNumber("M: ");
int[] arr = new int[length];
InputArrValues(arr);
Console.WriteLine($"Среди них, больше 0: {PositiveValuesNumber(arr)}");

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputArrValues(int[] arr)
{
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveValuesNumber(int[] arr)
{
    int posNum = 0;
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        if (arr[i] > 0) posNum++;
    }
    return posNum;
}
