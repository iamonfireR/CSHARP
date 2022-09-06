

class Program
{
    public static void Main(string[] args)
    {
        static int[] ArrayFill(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); // заполняем массив введенными числами
            }
            return arr;
        }

        static void TaskSolver(int[] arr)
        {
            int length = arr.Length;
            int counter = 0;              // счетчик
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0) counter++;
            }
            
            Console.WriteLine(counter); // вывод количества чисел больше 0
        }


        int quantity = int.Parse(Console.ReadLine()); //количество вводимых чисел
        int[] numbers = new int[quantity]; // массив с числами

        ArrayFill(numbers);
        TaskSolver(numbers);
    }
}