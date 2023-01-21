//Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
//[3,3 7,1 22,5 2,2 78,2] -> 76


using static System.Console;
Clear();

Write("Введите колличество элементов в массиве: ");
int.TryParse(ReadLine()!, out int size_array);
int[] array = GetArray(size_array);
PrintArray(array);
DeffNumMaxMin(array);


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

void DeffNumMaxMin(int[] inArray)
{
	int maxnum = inArray[0];
	int minnum = inArray[0];

	int[] ints = new int[inArray.Length];

	for (int i = 0; i < inArray.Length; i++)
	{

		if (maxnum < inArray[i]) maxnum = inArray[i];
		if (minnum > inArray[i]) minnum = inArray[i];
	}

	WriteLine(maxnum);
	WriteLine(minnum);
	WriteLine(maxnum- minnum);
    
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