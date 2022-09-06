using System.ComponentModel.Design.Serialization;
// Задача 43: Напишите программу, которая найдёт точку пересечения двух
//  прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

class Program
{
    public static void Main(string[] args)
    {
        static int[] ArrayFill(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Enter b1");
                        break;
                    case 1:
                        Console.WriteLine("Enter k1");
                        break;
                    case 2:
                        Console.WriteLine("Enter b2");
                        break;
                    case 3:
                        Console.WriteLine("Enter k2");
                        break;
                    default:
                        Console.WriteLine("Malfunction");
                        break;
                }
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int[] Calculations(int[] arr)  // b1[0] k1[1] b2[2] k2[3] double y = (k2*b1-k1*b2)/(k2-k1);
        {
            int length = arr.Length;
            double x = (arr[0] - arr[2]) / ((double)(arr[3] - arr[1]));
            double y = ((arr[3] * arr[0]) - (arr[1] * arr[2])) / ((double)(arr[3] - arr[1]));

            Console.WriteLine($"x- {x} | y- {y}");            

            return arr;
        }

        int[] coordinatesArr = new int[4];
  
        ArrayFill(coordinatesArr);
        Calculations(coordinatesArr);
    }
}
