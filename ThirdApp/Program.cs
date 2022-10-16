// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int GetNumberFromConsole(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int numM, int numN)

{
    if (numM == 0)
        return numN + 1;
    if (numM != 0 && numN == 0)
        return Ackerman(numM - 1, 1);
    if (numM > 0 && numN > 0)
        return Ackerman(numM - 1, Ackerman(numM, numN - 1));
    else
        return Ackerman(numM, numN);
}

int m = GetNumberFromConsole("Введите неотрицательное число m: ");
int n = GetNumberFromConsole("Введите неотрицательное число n: ");
Console.WriteLine($"Функция Аккермана для чисел {m} и {n}: A({m}, {n}) = {Ackerman(m, n)}.");