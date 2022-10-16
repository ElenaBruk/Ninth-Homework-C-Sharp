// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

double GetNumberFromConsole(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double SummaOfNumbers(double numM, double numN)
{
    if (numM <= numN)
    {
       if (numM - numN == 0)
            return numM;
        else
            return numM + SummaOfNumbers(numM + 1, numN);
    }
    else
    {
        if (numN - numM == 0)
            return numN;
        else
            return numN + SummaOfNumbers(numN + 1, numM);
    }
}

double m = Math.Truncate(GetNumberFromConsole("Введите вещественное значение переменной М: "));
double n = Math.Truncate(GetNumberFromConsole("Введите вещественное значение переменной N: "));
Console.Write($"Сумма натуральных элементов от {m} до {n} равна {SummaOfNumbers(m, n)}.");