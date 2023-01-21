//Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int.TryParse(ReadLine(), out int size_array);
int[] array = GetArray(size_array);
PrintArray(array);
WriteLine(SummOddNum(array));


int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}

int SummOddNum(int[] inArray)
{
    int summ = 0;
    int[] ints = new int[inArray.Length];

    foreach (int a in inArray)
    {
        if (a % 2 == 0) summ+=a;
        //summ += a % 2 > 0 ? a : 0;
    }
        
    //for (int i = 0; i < inArray.Length; i++)
    //{
    //    if (i % 2 > 0) summ += ints[i];
    //}
    
    return summ;
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