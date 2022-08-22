// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (line == column) Console.WriteLine("Введите разное количество cтрок и столбцов для формирования прямоугольного массива");
else
{
    int[,] array = new int[line, column];

    void MinimalSumLine(int[,] arrray)
    {
        int minSum = 0;
        int pos = 0;
        for (int y = 0; y < column; y++)
        {
            minSum = minSum + array[0, y];
        }

        for (int i = 0; i < line; i++)
        {
            int sum = 0;
            for (int j = 0; j < column; j++)
            {
                sum = arrray[i, j] + sum;
            }

            Console.WriteLine($"Cумма строки {i + 1} равна {sum}");

            if (sum <= minSum)
            {
                minSum = sum;
                pos = i + 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Минимальная сумма эллементов равная {minSum} и находится на строке {pos}");
    }
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    MinimalSumLine(array);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


