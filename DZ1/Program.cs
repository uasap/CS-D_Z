/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int val1 = 0,val2 = 0,val3 = 0;
string str1 ="";
string str2 = "";
string str3 = "";


Console.WriteLine("Задача 2");
Console.Write("Введите первое число  ");
str1 = Console.ReadLine();
if(str1 != "")
   val1 = int.Parse(str1);

Console.Write("Введите второе число  ");
str2 = Console.ReadLine();
if(str2 != "")
   val2 = int.Parse(str2);


Console.Write("max = " );
Console.WriteLine((val1 > val2)? val1 : val2 );

//===========================================================

Console.WriteLine("Задача 4");
Console.WriteLine("Введите первое число  ");
str1 = Console.ReadLine();
if(str1 != "")
   val1 = int.Parse(str1);

Console.Write("Введите второе число  ");
str2 = Console.ReadLine();
if(str2 != "")
   val2 = int.Parse(str2);

Console.Write("Введите третье число  ");
str3 = Console.ReadLine();
if(str3 != "")
   val3 = int.Parse(str3);

Console.Write("max = " );

int max = val1;
if(val2 > max)
   max = val2;
if(val3 > max)
   max = val3;

Console.WriteLine(max );


//=======================================================================
Console.WriteLine("Задача 6");

Console.Write("Введите  число  ");
str1 = Console.ReadLine();
if(str1 != "")
   val1 = int.Parse(str1);

Console.WriteLine((val1%2 == 0) ? "Четное число" : "Нечетное число") ;



//=======================================================================
Console.WriteLine("Задача 8");

Console.Write("Введите  число  ");
str1 = Console.ReadLine();
if(str1 != "")
   val1 = int.Parse(str1);

Console.Write("Четные :  ");
for (int i = 0; i <= val1; i++){
   if(i%2 == 0){
      Console.Write(i);
      if(i < val1)
         Console.Write(", ");
   }
}