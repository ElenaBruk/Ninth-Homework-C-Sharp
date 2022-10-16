// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

double GetNumberFromConsole()
{
    Console.Write("Введите вещественное значение числа N: ");
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbers(double numN)
{
    if (numN > 1)
    {
        Console.Write($"{numN}, ");
        WriteNumbers(numN - 1);
    }
    else if (numN == 1)
    {
        Console.Write(numN);
    }

    if (numN <= 0)
    {
        Console.WriteLine("В заданном промежутке нет натуральных чисел.");
    }
}

double numN = GetNumberFromConsole();
double n = (Math.Truncate(numN));
Console.Write($"Все натуральные числа от {numN} до 1: ");
WriteNumbers(n);