/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int Prompt(string message)
{
   System.Console.Write(message);
   string readInput = System.Console.ReadLine();
   int result = int.Parse(readInput);
   return result;
}

int Power(int powerBase, int exponent)
{
   int power = 1;
   for(int i = 0; i < exponent; i++){
      power *= powerBase;
   }
   return power;
}

bool ValidateExponent(int exponent)
{
    if(exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");

if(ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно  {Power(powerBase,exponent)}");
}


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int SummAllDigit(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number = number/10;
    }
    return result;
}

int number = Prompt("Введите число");
System.Console.WriteLine($"Сумма всех чисел в цифре{number} = {SummAllDigit( number)}");


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

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

int length = Prompt("Длина массива");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length,min,max);
PrintArray(array);