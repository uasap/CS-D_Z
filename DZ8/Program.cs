/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/



void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  сортировка элементов в строке двумерного массива, по убыванию
void SortLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[3, 4];
FillArrayRandom(array);
PrintArray(array);
SortLower(array);
Console.WriteLine("");
Console.WriteLine("Сортировка ");
PrintArray(array);


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
           sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

array = new int[4, 4];
FillArrayRandom(array);
Console.WriteLine("");
PrintArray(array);
Console.WriteLine("");
NumberRowMinSumElements(array);



/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int Prompt(string message)
{
   System.Console.Write(message);
   string readInput = System.Console.ReadLine();
   int result = int.Parse(readInput);
   return result;
}


int[,] MultArrays(int[,] array, int[,] secondArray, int rows, int columns){
        
    int[,] resultArray = new int[rows, columns];

    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
        return resultArray;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}

Console.WriteLine("");
int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");

array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray(array);

Console.WriteLine("");

FillArrayRandom(secondArray);
PrintArray(secondArray);

Console.WriteLine("");

int[,] resultArray = MultArrays(array,  secondArray,  rows,  columns);
Console.WriteLine("Результат умножения ");
Console.WriteLine("");
PrintArray(resultArray);




/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
На входе - натуральное число от пользователя, например 4.
Тогда на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/




//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    int e = 0;
    
    while(e < n * n)
    {
        int k = 0;
        e++;
        do { array[i, j++] = value++; } 
           while (++k < n - 1);

        for (k = 0; k < n - 1; k++) 
           array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) 
           array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) 
           array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
Console.WriteLine("");
int len = Prompt("Введите размер ");
array = new int[len, len];
FillArraySpiral(array, len);
PrintArray(array);

