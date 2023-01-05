// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SummEL(int m, int n)
{

    if (m > n) return 0;
    return SummEL(m + 1, n) + m;
}

Console.WriteLine("Enter Numbers: ");
Console.WriteLine(SummEL(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));