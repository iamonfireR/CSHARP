using System.ComponentModel;
using System;
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


class Program
{
    public static void Main(string[] args)
    {
        static int[] RandomArrGen( int[] arr)
        {  
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100, 999);
            }
            Console.WriteLine(string.Join(",", arr));

            return arr;
        }

        int[] CountEvenNums(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) 
                {
                    Console.WriteLine($"{arr[i]} Делится на 2 без остатка");
                    counter++;
                }
            }
            Console.WriteLine($"Количество четных чисел в массиве равняется- {counter}");
            return arr;
        }

        
        int size = new Random().Next(2, 25);
        Console.WriteLine($"Генерирую массив случайного размера... Размер: {size}");
        int[] numberArr = new int[size];

        RandomArrGen(numberArr);
        CountEvenNums(numberArr);
    }
}
