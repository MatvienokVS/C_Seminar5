//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 


using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int.TryParse(ReadLine(), out int size_array);
PrintArray(GetArray(size_array));



int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(101);

    }
    return array;
}


int InvertArray(int size)
{

    return Array;
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
}