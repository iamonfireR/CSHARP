// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


class Program
{   public static void Main(string[] args)
    {
        static int[] RandomArrGen( int[] arr)
        {  
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-100, 100);
            }
            Console.WriteLine(string.Join(",", arr));

            return arr;
        }

        int[] UnevenPositionSumm( int[] arr)
        {
            int summ = 0;
            for (int i = 1; i < arr.Length; i+=2)
            {
                summ += arr[i];
                 Console.WriteLine($"{summ}");

            }
            Console.WriteLine($"ИТОГ: {summ}");

            return arr;
        }


        int size = new Random().Next(2, 25);
        Console.WriteLine($"Генерирую массив случайного размера... Размер: {size}");
        int[] numberArr = new int[size];    

         RandomArrGen(numberArr);
         UnevenPositionSumm(numberArr);
    }
}