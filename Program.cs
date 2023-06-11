// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
// числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int Prompt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double[,] GetArray2d()
// {
//     int m = Prompt("Input m");
//     int n = Prompt("Input n");
//     double[,] array = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10)+new Random().NextDouble();
//         }
//     }
//     return array;
// }

// void PrintArray2d(double[,] array2d)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array2d[i, j],3) + " ");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] array2d = GetArray2d();
// PrintArray2d(array2d);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

// int Prompt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Input m");
//     int n = Prompt("Input n");
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray2d(int[,] array2d)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchNumber(int[,] array2d)
// {
//     int column = Prompt("Input column");
//     int row = Prompt("Input row");
//     if (column > array2d.GetLength(0) || row > array2d.GetLength(1))
//     {
//         Console.WriteLine("There is not element");
//     }
//     else Console.WriteLine(array2d[column - 1, row - 1]);
// }

// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// SearchNumber(array2d);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray2d()
{
    int m = Prompt("Input m");
    int n = Prompt("Input n");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void Average(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < array2d.GetLength(0); j++)
    {
        sum += array2d[j, i];
    }
    Console.Write(Math.Round(sum / array2d.GetLength(0),3)+" ");
}

}

int[,] array2d = GetArray2d();
PrintArray2d(array2d);

Average(array2d);