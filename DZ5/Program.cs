
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

//345, 897, 568, 234] -> 2

int[] GenerateArray(int Length, int minValue, int maxValue)
{
   int[] array = new int[Length];
   Random random = new Random();
   for(int i = 0; i < Length; i++)
   {
       array[i] = random.Next(minValue, maxValue + 1);
   }
   return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length-1; i++ )
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}


int GetNumEven(int[] array)
{
    int cnt = 0;
    for(int i = 0; i < array.Length; i++ )
    {
        if(array[i]%2 == 0)
           cnt++;
    } 
    return cnt; 
}

int[] array = GenerateArray(10,100,999);
PrintArray(array);
System.Console.WriteLine($"Число четных чисел = {GetNumEven(array)}");  


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
//нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int GetSumForEven(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++ )
    {
        if(i%2 == 1)
           sum += array[i];
    }
    return sum;      
}

array = GenerateArray(10,0,10);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {GetSumForEven(array)}");  


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void PrintArrayD(double[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length-1; i++ )
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

double[] GenerateArrayD(int Length, int minValue, int maxValue)
{
   double[] array = new double[Length];
   Random random = new Random();
   for(int i = 0; i < Length; i++)
   {
       array[i] = random.Next(minValue, maxValue + 1);
   }
   return array;
}

double GetDeltaMinMax(double[] array)
{    
    double min = array[0];
    double max = array[0];
     for(int i = 0; i < array.Length; i++)
   {
       if(array[i] > max)
          max =  array[i];
       if(array[i] < min)
          min =  array[i];
   }
   return max - min;
}

double[] arrayD = GenerateArrayD(10,-10,10);
PrintArrayD(arrayD);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {GetDeltaMinMax(arrayD)}");  