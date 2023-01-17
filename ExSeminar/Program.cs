//Переворот массива

using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int.TryParse(ReadLine(), out int size_array);
PrintArray(GetArray(size_array));
PrintArray(InvertArray(size_array));



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


int[] InvertArray(int size)
{
    int[] ints = GetArray(size);
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] *= -1;
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