using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program 
{
    public static void Main(string[] args)
    {
        int[] ArrayFill(int[] arr)
        {
            Console.WriteLine("Введите МИНИМАЛЬНЫЙ элемент массива...");
            int minN = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите МАКСИМАЛЬНЫЙ элемент массива...");
            int maxN = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(minN, maxN);
            }

            Console.WriteLine(string.Join(",", arr));

            return arr;

        }

    int size = new Random().Next(2, 25);
    Console.WriteLine($"Генерирую массив случайного размера... Размер: {size}");
    int[] numberArr = new int[size];

    ArrayFill(numberArr);
    }
}