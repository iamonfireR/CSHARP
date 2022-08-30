using System.ComponentModel;
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int number = int.Parse(Console.ReadLine()); // Рещение БЕЗ массива
// int exp = int.Parse(Console.ReadLine());
// int result = number;

// for (int i = 1; i < exp; i++)
// {
//     result = result * number; 
//     Console.WriteLine(result);
// }

// Console.WriteLine(result);

class Program
{
    public static void Main(string[] args)
    {
        void NumberToExpInput(int[] arr) // Это решение с массивом, где arr[0]- число arr[1] степень 
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Введите число, которое хотите возвести в степень...");
                        break;
                    case 1:
                        Console.WriteLine("Введите степень числа...");
                        break;
                    default:
                        Console.WriteLine("E R R O R");
                        break;
                }
                arr[i] = int.Parse(Console.ReadLine()); // Ввод чисел в массив
            }
        }

        void Calculate(int[] arr) // 
        {
            int result = arr[0];
            for (int i = 1; i < arr[1]; i++)
            {
                result = result * arr[0];
            }
            Console.WriteLine(result);
        }

        int[] numToExpArr = new int[2];

        NumberToExpInput(numToExpArr);
        Calculate(numToExpArr);
    }
}