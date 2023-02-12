// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Random rnd = new Random();
int start = rnd.Next(1, 7);
int end = rnd.Next(start + 1, 20);
Console.WriteLine($"M = {start}; N = {end} -> {SumNumbers(start, end)}");

int SumNumbers(int start, int end)
{
    if (start == end)
    {
        return end;
    }

    return start + SumNumbers(start + 1, end);
}
