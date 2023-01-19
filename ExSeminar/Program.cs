//Переворот массива

using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int.TryParse(ReadLine(), out int size_array);
int[] array = GetArray(size_array);
PrintArray(array);
PrintArray(InvertArray(array));



int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100,101);
    }
    return array;
}


int[] InvertArray(int[] inArray)
{
    int[] ints = new int[inArray.Length];
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = -inArray[i];
    }
    return ints;
}


void PrintArray(int[] array)
{
    Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    Write($"{array[array.Length-1]}");
    Write("]");
    WriteLine();
}