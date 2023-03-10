//Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int.TryParse(ReadLine(), out int size_array);
int[] array = GetArray(size_array);
PrintArray(array);
WriteLine(CountNum(array));


int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int CountNum(int[] inArray) 
{
    int count = 0;
    int[] ints = new int[inArray.Length];

    foreach (int i in inArray)
    {
        if (i % 2 == 0) count++;
    }
    return count;
}


void PrintArray(int[] array)
{
    Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    Write($"{array[array.Length - 1]}");
    Write("]");
    WriteLine();
}