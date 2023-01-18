//Написать программу которая проверяет присутствует ли число в массиве

using static System.Console;
Clear();


Write("Введите количество элементов массива и искомое число: ");
string[] param = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(param[0]));
PrintArray(array);


int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
    }
    return array;
}







void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Write($"{array[i]}, ");
    }
    Write($"{array[array.Length-1]}");
    Write("]");
}