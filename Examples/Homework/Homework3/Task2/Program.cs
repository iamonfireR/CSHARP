using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        void CoordintatesInput(int[] coordInput,int ArrayCounter)
        {
            switch (ArrayCounter) // Вывод соообщения о том, какая точква сейчас вводится
            {
                case 1:
                    Console.WriteLine("Введите координаты пераой точки");
                    break;
                case 2:
                    Console.WriteLine("Введите координаты второй точки");
                    break;
            }
            string CoordinateName = "default_name";
            int length = coordInput.Length;

            for (int i = 0; i < length; i++)
            {
                switch (i) // Для подстановки правильного наименования координаты в цикле
                {
                    case 0:
                        CoordinateName = "X";
                        break;
                    case 1:
                        CoordinateName = "Y";
                         break;
                    case 2:
                        CoordinateName = "Z";
                        break;
                    default: 
                        Console.WriteLine("Unexpected Error");
                        break;
                }
                Console.WriteLine($"Введите {CoordinateName} c клавиатуры");
                coordInput[i] = int.Parse(Console.ReadLine());
            }
        }

        void PrintInputtedCoords (int[] filledArr, int ArrayCounter)
        {
            switch (ArrayCounter)
            {
                case 1:
                    Console.WriteLine("Вывод в консоль первого массива");
                    break;
                case 2:
                    Console.WriteLine("Вывод в консоль второго массива");
                    break;
            }
            string CoordinateName = "default_name";
            int length = filledArr.Length;
            for (int i = 0; i < length; i++)
            {
                switch (i) // Для подстановки правильного наименования координаты в цикле
                {
                    case 0:
                        CoordinateName = "X";
                        break;
                    case 1:
                        CoordinateName = "Y";
                        break;
                    case 2:
                        CoordinateName = "Z";
                        break;
                    default:
                        Console.WriteLine("Unexpected ERROR");
                        break;

                }
                Console.WriteLine($"Значение {CoordinateName} = {filledArr[i]}");
            }
        }

        void DistanceFinder(int[] firstArr, int[] secondArr)
        {
            double result = 0;
            result = Math.Sqrt(Math.Pow(firstArr[0] - secondArr[0], 2) + Math.Pow(firstArr[1] - secondArr[1], 2) + Math.Pow(firstArr[2] - secondArr[2], 2));
            Console.WriteLine($"Расстоияние между Первой точкой с координатами X {firstArr[0]} Y {firstArr[1]} Z {firstArr[2]}");
            Console.WriteLine($"и второй точкой с координатами X {secondArr[0]} Y {secondArr[1]} Z {secondArr[2]}");
             Console.WriteLine($"равняется {result}");
        }
    
        int[] FirstCoordinates = new int[3];   //Массив для координат ПЕРВОЙ точки
        int[] SecondCoordinates = new int[3]; // Массив для координат ВТОРОЙ точки

        CoordintatesInput(FirstCoordinates, 1);    // Вызов метода заполнения ПЕРВОГО массива с клавиатуры
        PrintInputtedCoords(FirstCoordinates, 1); // Вызов метода показа ПЕРВОГО массива с клавиатуры

        CoordintatesInput(SecondCoordinates, 2);    // Вызов метода заполнения ВТОРОГО массива с клавиатуры
        PrintInputtedCoords(SecondCoordinates, 2); // Вызов метода показа ВТОРОГО массива с клавиатуры

        DistanceFinder(FirstCoordinates, SecondCoordinates); // Вызов метода подсчета расстояния
    }
}
