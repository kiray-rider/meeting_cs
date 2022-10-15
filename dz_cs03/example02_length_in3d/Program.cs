/*Задача 2. Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// Math.Sqrt() // команда квадратный корень

int X = 0;
int Y = 1;
int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point) // функция создания массива длиной в 3
{
    int[] answer = new int[3];
    answer[X] = Prompt($"Координата X, точка №{point}: ");
    answer[Y] = Prompt($"Координата Y, точка №{point}: ");
    answer[Z] = Prompt($"Координата Z, точка №{point}: ");
    return answer;
}

int square(int arg) // функция возведения в квадрат
{
    return arg * arg;
    // return Math.Pow(arg, 2); - или возведение в степень 2 через Math.Pow
}

System.Console.WriteLine("Введите ниже координаты двух точек в 3D пространстве:");
int[] point1 = InputPoint(1);
int[] point2 = InputPoint(2);

double lenght = Math.Sqrt(square(point1[X] - point2[X]) + square(point1[Y] - point2[Y]) + square(point1[Z] - point2[Z])); // <- Math.Sqrt

System.Console.Write("Расстояние между точками в 3D пространстве: ");
System.Console.WriteLine($"{lenght:f2}"); // f - количество знаков после запятой.
