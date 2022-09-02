


class Program
{   public static void Main(string[] args)
    {
        int[] ArrayFill(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 100);
            }

            Console.WriteLine(string.Join(",", arr));
            return arr;
        }

        int[] MinMaxFinder(int[] arr)
        {
            int minN = arr[1];
            int maxN = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                if (arr[i] > maxN) maxN = arr[i];
                if (arr[i] < minN) minN = arr[i]; 
            }

            int result = maxN - minN;

            Console.WriteLine(result);

            return arr;
        }

        int size = new Random().Next(10, 50);
        int[] numberArr = new int[size];

        ArrayFill(numberArr);
        MinMaxFinder(numberArr);
    }
}