// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = Get2DArray(2, 3);
double[] arithmeticMean = GetArithmeticMean(2, 3);
Print2DArray(array);

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t  ");
        }
        Console.WriteLine();
    }
}

int[,] Get2DArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 10);
        }
    }
    return array;

}

double[] GetArithmeticMean(int m, int n)
{
    double average = 0;
    double[] averages = new double[n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            average += array[i, j];
        }
        averages[i] = average / m;
        average = 0;
        Console.WriteLine();
    }
    for (int i = 0; i < averages.Length; i++)
    {
        Console.WriteLine($"Среднее = {averages[i]}");
    }
    return averages;
    Console.ReadLine();
}