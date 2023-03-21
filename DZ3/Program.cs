/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да
*/


bool CheckNumber(int num)
{
   int reverse = 0;
   int tmp = num;
   while(num!=0){
       int rank = num % 10;
       reverse = reverse*10 + rank;
       num = num/10;
   }

   return tmp == reverse;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
bool res = CheckNumber(num);

Console.WriteLine(res ? "Палиндром" : "Не палинром");


/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/


double Dist(double X1, double Y1, double Z1, double X2,double Y2, double Z2)
{
    return Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
}

Console.WriteLine("Введите X1");
double X1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y1");
double Y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Z1");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите X2");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y2");
double Y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Z2");
double Z2 = Convert.ToDouble(Console.ReadLine());

double D = Dist(X1, Y1, Z1, X2,Y2, Z2);
Console.WriteLine("Расстояние равно " + Convert.ToString(D));


/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/



void MakeDegree(int num)
{
   for(int i = 1; i <= num; i++){
      Console.WriteLine("Куб числа " + Convert.ToString(i) + " равен " + Convert.ToString(i*i*i));
   }
}

Console.WriteLine("Введите число");
num = Convert.ToInt32(Console.ReadLine());
MakeDegree( num);