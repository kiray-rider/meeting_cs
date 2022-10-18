// Задача 1. Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. Не применять строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//////////////////////////////////////////////////////////
//моё решение, через массив. Длинное
/* int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите пятизначное число: ");

while (number > 99999 | number < 10000)
{
    System.Console.WriteLine("Это число НЕ пятизначное!");
    number = Prompt("Введите пятизначное число: ");
}

 int[] array = new int[5];         // новый массив длинной в 5, заполненный нулями (решение через массив)
int numberWithoutEnd = number;
int index = array.Length - 1;

while (numberWithoutEnd > 0)
{
    array[index] = numberWithoutEnd % 10;
    numberWithoutEnd = (numberWithoutEnd - numberWithoutEnd % 10) / 10;
    index--;
    if (index < 0) break;
} 

if (array[4] == array[0] & array[3] == array[1])
{
    System.Console.WriteLine($"Число {number} является палиндромом!");
}
else
{
    System.Console.WriteLine($"Число {number} НЕ является палиндромом!");
}*/


//////////////////////////////////////////////////////////////////
// решение через сравнение с развернутым (реверснутым) числом

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ValidateNumber(int validNum) //проверка на 5и значность
{
    while (validNum > 99999 || validNum < 10000)
    {
        Console.WriteLine("Это число НЕ пятизначное!");
        validNum = Prompt("Введите пятизначное число: ");
    }
    return validNum;
}

int Reverse(int num) //создание переменной реверса для сравнения
{
    int reverse = 0;
    while (num > 0)
    {
        int value = num % 10;
        reverse = reverse * 10 + value;
        num = num /10;
    }
    return reverse;
}

bool IsPalindrome(int someNum) //проверка на палиндром в сравнении с реверсом
{
    return someNum == Reverse(someNum);
}

int number = Prompt("Введите пятизначное число: ");
number = ValidateNumber(number); //если закоментить строку - можно проверять не 5значные числа, но не больше 10значных (32битное ограничение)
if (IsPalindrome(number))
{
    System.Console.WriteLine($"Число {number} является палиндромом!");
}
else
{
    System.Console.WriteLine($"Число {number} НЕ является палиндромом!");
}
