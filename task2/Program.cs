// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
//ввести размер
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = Get2DArray(m, n);
Print2DArray(array);

int[,] Get2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позиции: ");
int column = Convert.ToInt32(Console.ReadLine());
int row = Convert.ToInt32(Console.ReadLine());

if (column > m || row > n)
    Console.WriteLine("Такого числа в массиве нет");
else
{
    object value = array.GetValue(column, row);
    Console.WriteLine(value);
}