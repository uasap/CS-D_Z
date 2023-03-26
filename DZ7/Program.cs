//адача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

int Prompt(string message)
{
   System.Console.Write(message);
   string readInput = System.Console.ReadLine();
   int result = int.Parse(readInput);
   return result;
}

double[,] GenerateArray(int LengthR,int LengthC)
{
   double[,] array = new double[LengthR, LengthC];
   Random random = new Random();
   for(int i = 0; i < LengthR; i++)
   {
       for(int j = 0; j < LengthC; j++)
          array[i,j] = random.NextDouble();
   }
   return array;
}

void PrintArray(double[,] array)
{    
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++ )
           System.Console.Write($"{array[i,j]}  ");
        System.Console.WriteLine("");
    }    
}


int length_r = Prompt("Число строк массива ");
int length_с = Prompt("Число столбцов массива ");
double[,] array = GenerateArray(length_r,length_с);
PrintArray(array);


//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

bool FindElement(int[,] array, int fvalue)
{
    bool find = false;
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++ ){
            if(fvalue == array[i,j]){
                find = true;
                break;
            }
        }        
    }  
    return find;
}


int[,] iarray = new int[,]{ { 1, 4 ,7, 2 }, { 5, 9, 2, 3 } , {8 ,4 ,2, 4 }};
int number = Prompt("Введите число ");
System.Console.WriteLine(FindElement(iarray, number) ? "-> такое число в массиве есть" : "-> такого числа в массиве нет");


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindAverage(int[,] array)
{
    System.Console.Write("Средние значения столбцов равны: ");
    for(int j = 0; j < array.GetLength(1); j++ )
    {
        double aver = 0;
        for(int i = 0; i < array.GetLength(0); i++ ){
            aver += array[i,j];
        }  
        aver /= array.GetLength(0); 
        System.Console.Write($"{aver}  , ");    
    }  
}

FindAverage(iarray);