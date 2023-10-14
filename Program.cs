// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NumbersBetween(int n, int m)
// {
//     if(n>0)
//     {
//      if (m < n)
//             NumbersBetween(n, m + 1);
//     Console.Write($"{m} ");
//     }
//     else
//     {
//     Console.WriteLine($"Input positive number, please!");
//     }
// }



// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = 1;
// NumbersBetween(n, m);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void SumFromMToN(int m, int n)
{
    Console.Write(BetweenMadnN(m - 1, n));
}

int BetweenMadnN(int m, int n)
{
    int res = m;
    if (m != n)
    {
        m++;
        res = m + BetweenMadnN(m, n);
        return res;
    }
    else return 0;
}

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());
SumFromMToN(n, m);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Я еще может попробую решить эту задачу.
// Извините, что не был в пятницу. Спасибо за уроки!