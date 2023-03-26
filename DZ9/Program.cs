/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int Prompt(string message)
{
   System.Console.Write(message);
   string readInput = System.Console.ReadLine();
   int result = int.Parse(readInput);
   return result;
}

void OutNaturalNum(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        OutNaturalNum(n, count + 1);
        Console.Write(count + " ");
    }
}


int number = Prompt("Введите число: ");
int count = 1;
OutNaturalNum(number, count);

/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


void SumFromMToN(int m, int n)
{
    Console.WriteLine($"Сумма чисел равна: {SumMN(m - 1, n)}");
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n){
        return 0;
    } else {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

Console.WriteLine("");
int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");

if( M <= N)
   SumFromMToN(M,N);
else
   Console.WriteLine("m должно быть меньше");


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int Akkerman(int m, int n)
{
    if (m == 0) {
        return n + 1;
    } else if (n == 0 && m > 0)  {
        return Akkerman(m - 1, 1);
    } else {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{
    Console.Write($" Значение Аккермана : {Akkerman(m, n)}"); 
}

Console.WriteLine("");
 M = Prompt("Введите число M: ");
 N = Prompt("Введите число N: ");

AkkermanFunction(M,N);