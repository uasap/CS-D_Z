/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
string[] origin = new string[] {"a", "ab", "abc", "abcde", "abcdef", "abcdef", "1", "12", "123", "1234"};
string[] array_out = new string[origin.Length];

void SortArray(string[] inbuf, string[] outbuf)
{
    int count = 0;
    for (int i = 0; i < inbuf.Length; i++)
    {
        if(inbuf[i].Length <= 3)
        {
           outbuf[count] = inbuf[i];
           count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SortArray(origin, array_out);
PrintArray(array_out);
