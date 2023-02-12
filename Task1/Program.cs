// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Random rnd = new Random();
int start = rnd.Next(1, 15);
Console.WriteLine($"N = {start} -> {PrintNumbers(start)}");

string PrintNumbers(int start)
{
    if (start == 1)
    {
        return start.ToString();
    }

    return (start + " " + PrintNumbers(start - 1));
}