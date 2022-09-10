
using System;
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9




int m = 3;
int n = 4;

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);

void FillArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double prettierNum = Math.Round(arr[i, j], 1);
            Console.Write(prettierNum + " ");
        }
        Console.WriteLine();
    }
}

 Console.WriteLine("---------------------------------------");




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// Как будто выходные данные от другого задания. Т.е (17, такого числа нет).
//По заданию мы должны ввести координаты и проверить если ли вообще такая ячайка и содежит ли она число.
//А пор выходным данным создается впечатление что мы ищем не ячейку, а само число, то есть не 1 строкаб 7 столб, а само число 17 в созданном массиве.
//Т.е. Ответ должен быть не "такого числа нет в массиве", а такой ячейки не сущетсвует, потому что 
//введенные коррдинаты ячейки выходят за область созданного массива.

void NumbersArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 100);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArraySearcher (int[,] arr)
{   
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());

    if(m < arr.GetLength(0) && n < arr.GetLength(1)) 
    {
        Console.WriteLine($"Элемент {m},{n} сущетсвует и равен {arr[m - 1,n - 1]}");
    }
    else Console.WriteLine("Таокго элемента не существует");

}

int[,] arrayN = new int[5,5];

NumbersArray(arrayN);
ArraySearcher(arrayN);

 Console.WriteLine("---------------------------------------");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void ArrayMfill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i, j] = new Random().Next(1,10);
           Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void TaskSolver(int[,] arr)
{
    double summ = 0;
    double[] result = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[j, i];
        }

        result[i] = summ / arr.GetLength(1);
        summ = 0;    
    }
    Console.WriteLine(string.Join(" | ", result));

}

int[,] arrayM = new int[5,5];

ArrayMfill(arrayM);
TaskSolver(arrayM);

Console.WriteLine("---------------------------------------");