/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

456 -> 5
782 -> 8
918 -> 1
*/


int InOut (string message)
{
   System.Console.Write(message);    
   return Convert.ToInt32(Console.ReadLine());
}

int number = InOut ("Введите трехзначное число : ");
if(number < 100 || number >= 1000)
{
    Console.WriteLine("Число не трехзначное");
    return;
}

Console.WriteLine($"Введенное число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");


//=================================================
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


int GetThird(int number)
{
   while(number > 999)
   {
       number /= 10;
   }
   return number % 10;
}

bool CheckNumber(int number)
{
    if(number < 100){
       Console.WriteLine("Третьей цифры нет");
       return false;
    }
    return true;
}

number = InOut ("Введите  число : ");
if(CheckNumber(number)){
   Console.WriteLine(GetThird(number));
}

//=================================================
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool IsWeekend(int weekDay)
{
   if(weekDay > 5){
      return true;
   }
   return false;
}

bool CheckWeekDay(int number)
{
    if(number > 0 && number <= 7){
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = InOut("Введите день недели :");
if(CheckWeekDay(weekDay)){
    if(IsWeekend(weekDay)){
       Console.WriteLine("Это выходной");
    } else
       Console.WriteLine("Это не выходной");

}








