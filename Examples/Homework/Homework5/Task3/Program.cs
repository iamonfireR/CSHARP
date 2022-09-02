// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

class Program
{
    public static void Main(string[] args)
    {
        static int[] RandomArrGen( int[] arr)
        {  
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 100);
            }
            Console.WriteLine(string.Join(",", arr));

            return arr;
        }

        int[] PairMult(int[] arr)
        {
            int mult = 0;
            int[] result = new int[arr.Length / 2];

            for (int i = 0; i < arr.Length / 2; i++)
            {
                mult = arr[i] * arr[(arr.Length - 1) - i];
                result[i] = mult;
            }
            Console.WriteLine(string.Join(",", result));

            return arr;
        }


        int size = new Random().Next(2, 8);
        Console.WriteLine($"Генерирую массив случайного размера... Размер: {size}");
        int[] numberArr = new int[size];    

        RandomArrGen(numberArr);
        PairMult(numberArr);
    }
}