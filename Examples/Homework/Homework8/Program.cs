using System;
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void ArrayFill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-_-_-_-_-_-");
}

int n = new Random().Next(3, 5);
int[,] arrayN = new int[n, n];

ArrayFill(arrayN);
PrintArray(arrayN);
SortingArray(arrayN);
PrintArray(arrayN);

//--------------------------------------------------------------------------------
// адача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("******************************************************");

void ArrayFillM(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArrayM(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-_-_-_-_-_-");
}

void Summ(int[,] arr)
{
    int counter = 0;
    int minSumm = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {summ}");
        if (i == 0)
        {
            minSumm = summ;
        }
        else if (summ < minSumm)
        {
            minSumm = summ;
            counter = i + 1;
        }
    }

    Console.WriteLine($"Min  sum of elements in ROW {counter}. ");
}



int[,] arrayM = new int[n, n];

ArrayFillM(arrayM);
PrintArrayM(arrayM);
Summ(arrayM);

Console.WriteLine("******************************************************");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void MatrixFill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("***");
}

void MatrixMult(int[,] arrA, int[,] arrB, int[,] res)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < res.GetLength(1); k++)
            {
                summ += arrA[i, k] * arrB[k, j];
            }
            res[i, j] = summ;
            Console.Write(res[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];
int[,] multMatrix = new int[2, 2];

MatrixFill(matrixA);
MatrixFill(matrixB);

MatrixMult(matrixA, matrixB, multMatrix);


Console.WriteLine("******************************************************");

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] arr3D = new int[2, 2, 2];
FillArray(arr3D);
PrintIndex(arr3D);


void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
    int fill = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += fill;
                fill += 1;
            }
        }
    }
}





Console.WriteLine("******************************************************");
// 

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralM = new int[4, 4];

int tmp = 1, i = 0, j = 0;

while (tmp <= spiralM.GetLength(0) * spiralM.GetLength(1))
{
  spiralM[i, j] = tmp;
  tmp++;
  if (i <= j + 1 && i + j <  spiralM.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >=  spiralM.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j >  spiralM.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralM);

void WriteArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}
  

Console.WriteLine("******************************************************");